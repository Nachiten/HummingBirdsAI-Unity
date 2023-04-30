using System.Runtime.CompilerServices;
using UnityEngine;

/// <summary>
/// Manages a single flower with nectar
/// </summary>
public class Flower : MonoBehaviour
{
    [Tooltip("The color when the flower is full")]
    public Color fullFlowerColor = new Color(1f, 0f, 0.3f);
    
    [Tooltip("The color when the flower is empty")]
    public Color emptyFlowerColor = new Color(0.5f, 0f, 1f);

    /// <summary>
    /// The trigger collider representing the nectar
    /// </summary>
    [HideInInspector]
    public Collider nectarCollider;
    
    // The solid collider representing the flower petals
    private Collider flowerCollider;
    
    // The flower's material
    private Material flowerMaterial;

    /// <summary>
    /// A vector pointing straight out of the flower
    /// </summary>
    public Vector3 FlowerUpVector => nectarCollider.transform.up;

    /// <summary>
    /// The center position of the nectar collider
    /// </summary>
    public Vector3 FlowerCenterPosition => nectarCollider.transform.position;

    /// <summary>
    /// The amount of nectar remaining in the flower
    /// </summary>
    public float NectarAmount
    {
        get;
        private set;
    }

    /// <summary>
    /// Whether the flower has nectar remaining
    /// </summary>
    public bool HasNectar => NectarAmount > 0f;
}
