using UnityEngine;

public class rotacion : MonoBehaviour
{
    // Velocidades por segundo (equivalen al movimiento anterior a 60 FPS)
    public float velAvance = 6f;   // unidades/segundo (flecha derecha)
    public float velSubida = 60f;  // unidades/segundo (flecha arriba)
    public float velGiroZ = 6f;    // grados/segundo (flecha izquierda)
    public float velGiroY = 6f;    // grados/segundo (flecha abajo)

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow)) {//getkey: mientras se mantiene presionada
            transform.Translate(0, 0, -velAvance * dt);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(0, 0, velGiroZ * dt);
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(0, velSubida * dt, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Rotate(0, -velGiroY * dt, 0);
        }
    }
}
