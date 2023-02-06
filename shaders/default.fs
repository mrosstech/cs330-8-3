# version 330 core
in vec3 ourColor;
in vec2 TexCoord;

uniform sampler2D texture1;

out vec4 FragColor;
void main()
{
    //FragColor = vec4(ourColor, 1.0f);
    FragColor = texture(texture1, TexCoord);
}