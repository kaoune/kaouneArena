using UnityEngine;
using System.Collections;

public class testServer : MonoBehaviour 
{

	private string ip = "";
	
	void Server()
	{
		Network.InitializeServer(2, 4242, false);
	}
	
	[RPC]
	void startPlay()
	{
		Application.LoadLevel("tracktest");
	}
	
	void Client(string ip)
	{
		Network.Connect(ip,4242);
	}
	
	[RPC]
	void changeScreenColor(int c)
	{
		switch(c)
		{
			case 0:	camera.backgroundColor = Color.red; break;
			case 1:	camera.backgroundColor = Color.green; break;
			case 2:	camera.backgroundColor = Color.blue; break;
		}
	}
	
	void OnGUI()
	{
		if(Network.isClient)
		{
			GUILayout.Label("client");
			return;
		}
		if(Network.isServer)
		{
			GUILayout.Label("server");
			if(GUILayout.Button("Play"))
				networkView.RPC("startPlay", RPCMode.All);
				
			return;
		}
		
		if(GUILayout.Button ("create"))
			Server();
		if(GUILayout.Button("Connect"))
			Client(ip);
		
		ip = GUILayout.TextField(ip);
	}
}
