using UnityEngine;

namespace KS
{
    public class MouseLook : MonoBehaviour
    {
        GameObject player;


        [SerializeField] float minClamp = -45f; //rajoitetaan pään ylös/alas liikkumista
        [SerializeField] float maxClamp = 45f;

        Vector2 rotation;
        Vector2 currentLookRotation;
        Vector2 rotationVelocity = new Vector2(0, 0);

        [SerializeField] float lookSensitivy = 2.0f; // kääntymisnopeuden säätö'
        [SerializeField] float lookSmoothDamp = 0.1f; // tasataan ylös/alas päänkääntöä

        private void Awake()
        {
            player = transform.parent.gameObject;           
        }

        private void Update()
        {
            rotation.y += Input.GetAxis("Mouse Y") * lookSensitivy;

            //rajoitetaan pään liikkuminen minClamp ja maxClamp-arvojen mukaan
            rotation.y = Mathf.Clamp(rotation.y, minClamp, maxClamp);

            //käännetään pelihahmoa paikallaan hiiren x-arvon mukaisesti
            player.transform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * lookSensitivy);

            //tasataan nykyinen(current) y-rotaatio ylös/alas päänkääntöön
            currentLookRotation.y = Mathf.SmoothDamp(currentLookRotation.y, rotation.y, ref rotationVelocity.y, lookSmoothDamp);

            //transform = kamera, jossa skripti kiinni
            //päivitetään kameran x-rotaatio vastaamaan hiirellä annettuja liikkumisarvoja
            transform.localEulerAngles = new Vector3(-currentLookRotation.y, 0, 0);
        }
    }

}