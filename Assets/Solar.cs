using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solar : MonoBehaviour
{

    public Transform sun;
    public Transform mercury;
    public Transform venus;
    public Transform earth;
    public Transform mars;
    public Transform jupiter;
    public Transform saturn;
    public Transform uranus;
    public Transform neptune;



    // Start is called before the first frame update
    void Start()
    {
        sun.position = Vector3.zero;
        mercury.position = new Vector3(5, 0, 0);
        venus.position = new Vector3(8, 1, 0);
        earth.position = new Vector3(11, 2, 0);
        mars.position = new Vector3(14, 3, 0);
        jupiter.position = new Vector3(20, -1, 0);
        saturn.position = new Vector3(27, -2, 0);
        uranus.position = new Vector3(35, -3, 0);
        neptune.position = new Vector3(40, 0, 0);

        sun.localScale = new Vector3(7, 7, 7);
        mercury.localScale = new Vector3(1, 1, 1);
        venus.localScale = new Vector3(2, 2, 2);
        earth.localScale = new Vector3(2, 2, 2);
        mars.localScale = new Vector3(1, 1, 1);
        jupiter.localScale = new Vector3(5, 5, 5);
        saturn.localScale = new Vector3(5, 5, 5);
        uranus.localScale = new Vector3(3, 3, 3);
        neptune.localScale = new Vector3(3, 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        mercury.RotateAround(sun.position, new Vector3(0, 1, 0), 100 * Time.deltaTime);
        mercury.Rotate(Vector3.up * 30 * Time.deltaTime);

        venus.RotateAround(sun.position, new Vector3(1, -8, 0), 90 * Time.deltaTime);
        venus.Rotate(Vector3.up * 30 * Time.deltaTime);

        earth.RotateAround(sun.position, new Vector3(2, -11, 0), 80 * Time.deltaTime);
        earth.Rotate(Vector3.up * 30 * Time.deltaTime);

        mars.RotateAround(sun.position, new Vector3(3, -14, 0), 70 * Time.deltaTime);
        mars.Rotate(Vector3.up * 30 * Time.deltaTime);

        jupiter.RotateAround(sun.position, new Vector3(1, 20, 0), 60 * Time.deltaTime);
        jupiter.Rotate(Vector3.up * 30 * Time.deltaTime);

        saturn.RotateAround(sun.position, new Vector3(2, 27, 0), 50 * Time.deltaTime);
        saturn.Rotate(Vector3.up * 30 * Time.deltaTime);

        uranus.RotateAround(sun.position, new Vector3(3, 35, 0), 40 * Time.deltaTime);
        uranus.Rotate(Vector3.up * 30 * Time.deltaTime);

        neptune.RotateAround(sun.position, new Vector3(0, 2, 1), 30 * Time.deltaTime);
        neptune.Rotate(Vector3.up * 30 * Time.deltaTime);

        
    }
}
