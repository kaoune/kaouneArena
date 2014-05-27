Shader "Custom/myDiffuse" 
{
	Properties
	{
		_Color ("Color (rgb)", Color) = (1,1,1,1)
		_MainTex ("Texture principale (RGB)", 2D) = "white"
	}
	
	SubShader 
	{
		CGPROGRAM
		#pragma surface surf Lambert
			struct Input 
			{
				float2 uv_MainTex;
			};
			
			float4 _Color;
			sampler2D _MainTex;
	
			void surf (Input IN, inout SurfaceOutput o) 
			{
				o.Albedo = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			}
		ENDCG
	} 
	FallBack "Diffuse"
}
