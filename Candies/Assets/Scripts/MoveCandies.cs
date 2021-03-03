using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCandies : MonoBehaviour
{
    public static int count;
    public GameObject nextText;
    private Vector3 candyPos;
    private float speedToBox = 5f;
    private bool isMoveToBox;
    private Collider _collider;
    
    private void Start() {
        _collider = GetComponent<Collider>();
    }

    void OnMouseDown() {
        candyPos = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f)); 
    }

    void OnMouseDrag() {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + candyPos;
    }

    private void OnTriggerStay(Collider other) {
        switch(gameObject.name) {
            case "Candy1":
                if(other.tag == "Candy1") {
                    isMoveToBox = true;
                    StartCoroutine(MoveToBox(new Vector3(0.666f, 0.187f, -0.236f)));
                    _collider.enabled = false;
                    StartCoroutine(Next());
                }
            break;
            case "Candy2":
                if(other.tag == "Candy2") {
                    isMoveToBox = true;
                    StartCoroutine(MoveToBox(new Vector3(0.5422592f, 0.16f, -0.57f)));
                    _collider.enabled = false;
                    StartCoroutine(Next());
                }
            break;
            case "Candy3":
                if(other.tag == "Candy3") {
                    isMoveToBox = true;
                    StartCoroutine(MoveToBox(new Vector3(0.16f, 0.19f, -0.3f)));
                    _collider.enabled = false;
                    StartCoroutine(Next());
                }
            break;
            case "Candy4":
                if(other.tag == "Candy4") {
                    isMoveToBox = true;
                    StartCoroutine(MoveToBox(new Vector3(-0.2f, 0.1f, -0.31f)));
                    _collider.enabled = false;
                    StartCoroutine(Next());
                }
            break;
            case "Candy5":
                if(other.tag == "Candy5") {
                    isMoveToBox = true;
                    StartCoroutine(MoveToBox(new Vector3(-0.5f, 0.19f, -0.47f)));
                    _collider.enabled = false;
                    StartCoroutine(Next());
                }
            break;
            case "Candy6":
                if(other.tag == "Candy6") {
                    isMoveToBox = true;
                    StartCoroutine(MoveToBox(new Vector3(-0.62f, 0.158f, -0.131f)));
                    _collider.enabled = false;
                    StartCoroutine(Next());
                }
            break;
            case "Candy7":
                if(other.tag == "Candy7") {
                    isMoveToBox = true;
                    StartCoroutine(MoveToBox(new Vector3(0.28f, 0.19f, 0.21f)));
                    _collider.enabled = false;
                    StartCoroutine(Next());
                }
            break;
            case "Candy8":
                if(other.tag == "Candy8") {
                    isMoveToBox = true;
                    StartCoroutine(MoveToBox(new Vector3(-0.186f, 0.09f, 0.304f)));
                    _collider.enabled = false;
                    StartCoroutine(Next());
                }
            break;
        }
    }

    IEnumerator MoveToBox(Vector3 posInBox) {
        while(isMoveToBox) {
            isMoveToBox = true;
            if(transform.localPosition != posInBox)
                transform.localPosition = Vector3.MoveTowards(transform.localPosition, posInBox, speedToBox * Time.deltaTime);
            else
                break;
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator Next() {
        nextText.SetActive(true);
        count++;
        yield return new WaitForSeconds(1f);
        nextText.SetActive(false);
    }
}
