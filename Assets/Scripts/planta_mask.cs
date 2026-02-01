using UnityEngine;

public class planta_mask : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        red r= collision.collider.GetComponent<red>();
        if (r != null && Input.GetKey(KeyCode.E))
        {
            r.ActivarMascara(red.Tipo_mascara.Planta);
            Destroy(gameObject);
        }
    }
}