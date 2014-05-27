Shader "Custom/rim" {
	Properties {
	
		_Color ("Color", color) = (0,0,1,1)
		_MainTex ("Texture (RGB)", 2D) = "white" {}
		_LineTex ("LineTexture (RGB)", 2D) = "white" {}
		_Speed ("Speed", float) = 1
		_RimPower ("Rim Power", Range(0,10)) = 1
	}
	SubShader {
	
		tags{ "Queue"="Transparent"}
		
		Pass
		{
			ZWrite On
			ColorMask 0
		}
		
		Blend One One
		CGPROGRAM
		#pragma surface surf Lambert

			struct Input 
			{
				float2 uv_MainTex;
				float3 worldPos;
				float3 viewDir;
				float3 worldNormal;
				float4 screenPos;
			};
			
			float4 _Color;
			float _Speed;
			sampler2D _MainTex;
			sampler2D _LineTex;
			float _RimPower;
			
			void surf (Input IN, inout SurfaceOutput o) 
			{
				float grey = tex2D(_MainTex, IN.uv_MainTex).rgb;
				float2 screenUV = ((IN.worldPos.xy) * 3) + (_Time * _Speed);
				float line = tex2D(_LineTex, screenUV).rgb;
				float rim = 1.0 - saturate(dot(normalize(IN.worldNormal), normalize(IN.viewDir)));
				o.Albedo = ((grey * _Color) * (line));
				o.Emission = ((grey * _Color) * (line)) + (_Color * pow(rim, _RimPower));
				o.Alpha = tex2D(_MainTex, IN.uv_MainTex).a;
			}
		ENDCG
	} 
}
