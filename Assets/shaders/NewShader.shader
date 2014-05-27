Shader "TutoShaderLabs/Color"
{
	Properties
	{
		_Color ("Color (rgb)", Color) = (1,1,1,1)
	}
	SubShader
	{
		Pass
		{
			Color [_Color]
		}
	}
}
