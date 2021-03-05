using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Me.DerangedSenators.CopsAndRobbers
{
    public class AttackCircle : MonoBehaviour
    {
        public AttackVector Vector;
        
        // Update is called once per frame
        void Update()
        {
            //transform.position = playerAttack.GetAttackPoint();
            transform.position = new Vector3(Vector.GetAttackPoint(0.4f).x, Vector.GetAttackPoint(0.4f).y, 0);

        }
    }
}