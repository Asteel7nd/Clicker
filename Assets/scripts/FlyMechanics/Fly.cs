using UnityEngine;


namespace Asteel7nd.Fly
{
    public class Fly : MonoBehaviour
    {
        public int Spin {  get; private set; }


        void Start()
        {
            Rigidbody2D Rb = GetComponent<Rigidbody2D>();
            Rb.AddForce(new Vector3(Random.Range(-5, 5), 10), ForceMode2D.Impulse);
            Spin = Random.Range(400, -400);
        }

        void Update()
        {
            var rotation = Time.deltaTime * Spin;
            transform.Rotate(new Vector3(0, 0, rotation));
        }
    }
}
