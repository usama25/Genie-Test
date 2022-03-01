using UnityEngine;
using System.Collections;

public class example : MonoBehaviour {

    public GameObject ColorPickedPrefab;
    private ColorPickerTriangle CP;
    private bool isPaint = false;
    public GameObject go;
    public Material mat;

    void Start()
    {
       
    }

    void Update()
    {
        if (isPaint)
        {
            mat.color = CP.TheColor;
        }
    }

    void OnMouseDown()
    {
        StartPaint();
    }

    private void StartPaint()
    {
        //go = (GameObject)Instantiate(ColorPickedPrefab);
        //go.transform.localScale = Vector3.one * 1.3f;
        //go.transform.LookAt(Camera.main.transform);
        CP = go.GetComponent<ColorPickerTriangle>();
        Debug.Log(mat.name);
        CP.SetNewColor(mat.color);
        isPaint = true;
    }

    private void StopPaint()
    {
        Destroy(go);
        isPaint = false;
    }
}
