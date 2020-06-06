using UnityEngine;

namespace MegaTools.Utils
{
    [RequireComponent(typeof(Rigidbody))]
    public class RigidbodyCenterOfMass : MonoBehaviour
    {
        public Vector3 CenterOfMass = new Vector3(0, 0, 0);
        private Rigidbody _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            _rb.centerOfMass = CenterOfMass;
        }
    }
}
