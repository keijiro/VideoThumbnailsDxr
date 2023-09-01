using UnityEngine;

namespace UnityPhysics {

sealed class Spawner : MonoBehaviour
{
    [field:SerializeField] public GameObject Prefab { get; set; }
    [field:SerializeField] public int Rows { get; set; }
    [field:SerializeField] public Vector3 Interval { get; set; }

    void Start()
    {
        var rot = Quaternion.identity;
        for (var row = 0; row < Rows; row++)
        {
            var y = Interval.y * row;
            var offs = (Rows - row - 1) * 0.5f;
            for (var i = 0; i < Rows - row; i++)
            {
                var x = Interval.x * (i - offs);
                for (var j = 0; j < (Interval.z == 0 ? 1 : Rows - row); j++)
                {
                    var z = Interval.z * (j - offs);
                    var pos = new Vector3(x, y, z) + transform.position;
                    Instantiate(Prefab, pos, rot);
                }
            }
        }
    }
}

} // namespace UnityPhysics
