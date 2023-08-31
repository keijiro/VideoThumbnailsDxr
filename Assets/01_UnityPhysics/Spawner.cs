using UnityEngine;

namespace UnityPhysics {

sealed class Spawner : MonoBehaviour
{
    [field:SerializeField] public GameObject Prefab { get; set; }
    [field:SerializeField] public int Rows { get; set; }
    [field:SerializeField] public Vector2 Interval { get; set; }

    void Start()
    {
        for (var row = 0; row < Rows; row++)
        {
            var y = Interval.y * row;
            for (var col = 0; col < Rows - row; col++)
            {
                var x = Interval.x * (col - (Rows - row - 1) * 0.5f);
                Instantiate(Prefab, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }
}

} // namespace UnityPhysics
