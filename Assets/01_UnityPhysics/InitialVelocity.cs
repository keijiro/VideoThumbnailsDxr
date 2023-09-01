using UnityEngine;

namespace UnityPhysics {

sealed class InitialVelocity : MonoBehaviour
{
    [field:SerializeField] public Vector3 Velocity { get; set; }

    void Start()
      => GetComponent<Rigidbody>().velocity = Velocity;
}

} // namespace UnityPhysics
