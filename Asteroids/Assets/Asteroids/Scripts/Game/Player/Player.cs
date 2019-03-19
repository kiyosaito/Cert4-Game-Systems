using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids {

    public class Player : MonoBehaviour {

        public float movementSpeed = 10f;
        public float rotationSpeed = 360f;

        private Rigidbody2D rigid;

        void Start() {
            rigid = GetComponent<Rigidbody2D>();
        }

        void Control() {
            if(Input.GetKey(KeyCode.UpArrow)) {
                rigid.AddForce(transform.up * movementSpeed);
            }
            if(Input.GetKey(KeyCode.DownArrow)) {
                rigid.AddForce(transform.up * -movementSpeed);
            }

            if(Input.GetKey(KeyCode.LeftArrow)) {
                rigid.rotation += rotationSpeed * Time.deltaTime;
            }
            if(Input.GetKey(KeyCode.RightArrow)) {
                rigid.rotation -= rotationSpeed * Time.deltaTime;
            }
        }

        void Update() {
            Control();
        }
    }
}
