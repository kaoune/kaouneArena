using UnityEngine;
using System.Collections;

[RequireComponent (typeof(NetworkView))]
public class Pod1 : MonoBehaviour 
{
    /* Sensibilité des controles de rotation */
    public float sens;

    /* 4 points de raycast (Top, Bottom, Left, Right). /!\ Respectez l'odre */
    public Transform[] raycastPosition;

    /* Distance max des raycast avant que le Pod ne soit plus "grounded" */
    public float rayDist;

    /* Rotation max par seconde pour aligner le Pod avec le sol */
    public float maxAngleDif;

    public GameObject meshPod;

    public Rigidbody physicPod;

    public Vector3 offset;

    public float acc;

    [HideInInspector]
    public bool isGrounded = false;

    void Start()
    {
        /* Si on est en réseau et que le pod n'est pas le notre on désactive les controles */
        if ((Network.isClient || Network.isServer) && networkView.isMine == false)
            this.enabled = false;
    }

    void Update()
    {
        /* 
         * On declare les deux Vector3 qui vont contenir les positions des points de collisions des raycasts
         * Ils sont utilisés deux fois (Top Bottom puis Left right)
         */
        Vector3 p1, p2;

        /*
         * On récupère les position des points de collisions des raycast Top et Bottom (raycastPosition[0] et raycastPosition[1])
         * On utilise ces raycast pour savoir si le pod est au sol ou pas (isGrouded)
         * Il faudrait faire un dessin pour expliquer le calcule ( on se voit a la rentrée ;) )
         */
        if (Raycast(0, out p1) && Raycast(1, out p2))
        {
            isGrounded = true;
            float angle1 = Vector3.Angle(p1 - raycastPosition[0].position, p2 - raycastPosition[0].position);
            float angle2 = Vector3.Angle(p2 - raycastPosition[1].position, p1 - raycastPosition[1].position);
            meshPod.transform.Rotate(Vector3.right * 
                Mathf.Clamp(
                    (angle1 - angle2) / 2.0f,
                    (-maxAngleDif / 2.0f) * Time.deltaTime,
                    (maxAngleDif / 2.0f) * Time.deltaTime)
                );
        }
        /*
         * Si Top ou Bottom ne touche pas le sol alors le Pod est en l'air
         */
        else
        {
            isGrounded = false;
        }

        /*
         * Meme chose pour Left et Right sinon le Pod déconne
         */
        if (Raycast(2, out p1) && Raycast(3, out p2))
        {
            float angle1 = Vector3.Angle(p1 - raycastPosition[2].position, p2 - raycastPosition[2].position);
            float angle2 = Vector3.Angle(p2 - raycastPosition[3].position, p1 - raycastPosition[3].position);
            transform.Rotate(Vector3.forward * 
                Mathf.Clamp(
                    (angle1 - angle2) / 2.0f, 
                    (-maxAngleDif / 2.0f) * Time.deltaTime, 
                    (maxAngleDif / 2.0f) * Time.deltaTime)
                );
        }
        float direction = Input.GetAxis("Horizontal");
      //  float direction = HorizontalInput.instance.GetAxis();
        meshPod.transform.Rotate(sens * Vector3.up * direction * Time.deltaTime);
    }

    bool Raycast(int index, out Vector3 pos)
    {
        pos = Vector3.zero;
        Ray ray = new Ray(raycastPosition[index].position, -raycastPosition[index].up);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayDist))
        {
            pos = hit.point;
            return true;
        }
        return false;
    }
}
