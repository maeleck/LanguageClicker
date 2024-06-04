using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScroll : MonoBehaviour
{
    public float scrollSpeed = 100.0f;
    public Vector2 minBoundary; // Set these in the Inspector
    public Vector2 maxBoundary; // Set these in the Inspector

    private Vector2 lastMousePosition;
    private bool isDragging = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
            isDragging = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging)
        {
            Vector2 currentMousePosition = Input.mousePosition;
            Vector2 deltaPosition = (currentMousePosition - lastMousePosition) * scrollSpeed * Time.deltaTime;

            // Calculate the new position
            Vector3 newPosition = transform.position - new Vector3(deltaPosition.x, deltaPosition.y, 0);

            // Clamp the new position to the boundaries
            newPosition = ClampPositionToBounds(newPosition);

            // Apply the clamped position
            transform.position = newPosition;

            lastMousePosition = currentMousePosition;
        }
    }

    Vector3 ClampPositionToBounds(Vector3 proposedPosition)
    {
        // Clamp the x and y values of the proposed position to the min and max boundaries
        float clampedX = Mathf.Clamp(proposedPosition.x, minBoundary.x, maxBoundary.x);
        float clampedY = Mathf.Clamp(proposedPosition.y, minBoundary.y, maxBoundary.y);

        // Return the clamped position, maintaining the original z position
        return new Vector3(clampedX, clampedY, proposedPosition.z);
    }
}