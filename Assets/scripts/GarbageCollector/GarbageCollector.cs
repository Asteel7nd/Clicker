using UnityEngine;


namespace Asteel7nd.Collector
{
    public class GarbageCollector : MonoBehaviour
    {
        public string DestroyTag;


        private void Start()
        {
            if (DestroyTag == "" || DestroyTag == null)
            {
                DestroyTag = "Money";
            }
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(DestroyTag))
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
