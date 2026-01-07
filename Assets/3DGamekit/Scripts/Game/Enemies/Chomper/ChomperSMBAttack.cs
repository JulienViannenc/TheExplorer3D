using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    public class ChomperSMBAttack : SceneLinkedSMB<ChomperBehavior>
    {
        protected Vector3 m_AttackPosition;

        public override void OnSLStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnSLStateEnter(animator, stateInfo, layerIndex);

            m_MonoBehaviour.controller.SetFollowNavmeshAgent(false);

            m_AttackPosition = m_MonoBehaviour.target.transform.position;
            Vector3 toTarget = m_AttackPosition - m_MonoBehaviour.transform.position;
            toTarget.y = 0;

            m_MonoBehaviour.transform.forward = toTarget.normalized;
            m_MonoBehaviour.controller.SetForward(m_MonoBehaviour.transform.forward);

            Debug.Log("Audio Attack Chomper Triggered");
            m_MonoBehaviour.event_Ennemy_Chomper_Attack_Play.Post(m_MonoBehaviour.AS_MOUTH);

        }

        public override void OnSLStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnSLStateExit(animator, stateInfo, layerIndex);

            m_MonoBehaviour.event_Ennemy_Chomper_Attack_Stop.Post(m_MonoBehaviour.AS_MOUTH);


            m_MonoBehaviour.controller.SetFollowNavmeshAgent(true);
        }
    }
}