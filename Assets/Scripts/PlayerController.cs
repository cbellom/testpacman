using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;

    private float bonusSpeed;
    private Rigidbody rb;
    private Renderer rend;    

    void Start() {
        bonusSpeed = 0f;
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
    }

    void Update() {
        if(bonusSpeed>0)
            rend.material.color = Color.red;
        else
            rend.material.color = Color.yellow;
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * (speed+ bonusSpeed));
    }

    public void ActiveSpeedBonus(int bonus) {
        StartCoroutine(ActiveBonus(bonus));
    }

    IEnumerator ActiveBonus(int bonus) {
        AddBonusSpeed(bonus);
        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);
        RemoveBonusSpeed(bonus);
    }


    void AddBonusSpeed(int bonus) {
        bonusSpeed += bonus;
    }

    void RemoveBonusSpeed(int bonus) {
        bonusSpeed -= bonus;
        rend.material.color = Color.yellow;
    }

}
