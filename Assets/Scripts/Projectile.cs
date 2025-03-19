using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);      
    }

   

    //TEE PROJECTILESTA PREFAB JA POISTA SE SKENEST�
    // LUO TOIMINNALLISUUS, ETT� KUN PELAAJA PAINAA 
    // VAS. HIIREN NAPPIA, INSTANSIOIDAAN UUSI PROJECTILE
    // CAMERAN CHILD-GAMEOBJEKTISTA

    //VOIT K�YTT�� ESIM. Input.GetButtonDown("Fire1") //hiiren vasen

    // LIS�� TOIMINNALLISUUS: JOS PROJECTILE OSUU MIHIN TAHANSA,
    // SE TUHOTAAN. ASETA PROJECTILE OMAAN LAYERIINSA,
    // JA LUO PLAYERILLE OMA LAYERINSA.
    // POISTA LAYER COLLISION MATRIXISTA PLAYERin ja PROJECTILEn 
    // T�RM��MINEN
}
