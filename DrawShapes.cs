using UnityEngine;
using UnityEngine.UI;

public class DrawShapes : MonoBehaviour
{
    public int textureWidth = 600; // Width of the texture
    public int textureHeight = 600; // Height of the texture
    public Color32 backgroundColor = Color.white; // Background color of the texture

    private Texture2D texture; // Reference to the texture

    void Start()
    {
        // Create a new texture
        texture = new Texture2D(textureWidth, textureHeight);
        ClearTexture(); // Clear the texture with the background color

        // Draw multiple houses
        int gridSize = 6; // Number of houses per row and column
        int houseSpacing = 80; // Spacing between houses

        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                Vector2Int position = new Vector2Int((i * houseSpacing) + (50), (j * houseSpacing) + (50));
                DrawHouse(position); // Draw a house at the calculated position
            }
        }

        // Apply changes to the texture
        texture.Apply();

        // Assign the texture to a Raw Image component
        RawImage rawImage = GetComponent<RawImage>();
        if (rawImage != null)
        {
            rawImage.texture = texture;
        }
    }

    // Draw a house shape
    void DrawHouse(Vector2Int position)
    {
        DrawRectangle(position - new Vector2Int(30, 30), 60, 60, Color.red); // Base
        DrawRectangle(position - new Vector2Int(10, 30), 20, 30, Color.black); // Door
    }







    // Draw a rectangle shape
    void DrawRectangle(Vector2Int position, int width, int height, Color color)
    {
        for (int x = position.x; x < position.x + width; x++)
        {
            for (int y = position.y; y < position.y + height; y++)
            {
                texture.SetPixel(x, y, color);
            }
        }
    }

    // Draw a triangle shape
    void DrawTriangle(Vector2Int point1, Vector2Int point2, Vector2Int point3, Color color)
    {
        DrawLine(point1, point2, color);
        DrawLine(point2, point3, color);
        DrawLine(point3, point1, color);
    }

    // Draw a line between two points
    void DrawLine(Vector2Int start, Vector2Int end, Color color)
    {
        int dx = Mathf.Abs(end.x - start.x), dy = Mathf.Abs(end.y - start.y), sx = start.x < end.x ? 1 : -1, sy = start.y < end.y ? 1 : -1, err = dx - dy;

        while (true)
        {
            texture.SetPixel(start.x, start.y, color);

            if (start.x == end.x && start.y == end.y)
                break;

            int e2 = 2 * err;
            if (e2 > -dy) { err -= dy; start.x += sx; }
            if (e2 < dx) { err += dx; start.y += sy; }
        }
    }

    // Clear the texture with the background color
    void ClearTexture()
    {
        Color32[] pixels = new Color32[textureWidth * textureHeight];
        for (int i = 0; i < pixels.Length; i++)
        {
            pixels[i] = backgroundColor;
        }
        texture.SetPixels32(pixels);
    }
}
