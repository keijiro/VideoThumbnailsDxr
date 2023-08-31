using UnityEngine;

namespace UnityPhysics {

sealed class Spawner : MonoBehaviour
{
    [field:SerializeField] public GameObject Prefab { get; set; }
    [field:SerializeField] public int SpawnCount { get; set; } = 10;
    [field:SerializeField] public float SpawnRadius { get; set; } = 3;

    void Start()
    {
        var origin = transform.position;
        for (var i = 0; i < SpawnCount; i++)
        {
            var pos = Random.insideUnitSphere * SpawnRadius + origin;
            var rot = Random.rotation;
            Instantiate(Prefab, pos, rot);
        }
    }
}

} // namespace UnityPhysics
