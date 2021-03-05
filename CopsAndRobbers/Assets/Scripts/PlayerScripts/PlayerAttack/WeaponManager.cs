using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using Mirror;
using Mirror.SimpleWeb;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Me.DerangedSenators.CopsAndRobbers
{
    /// <summary>
    /// Class designed to manage the weapon equipped by the player. It is used to instantiate new weapons, facilitate weapon switching and provide weapon prefabs the information they require to perform attacks
    /// </summary>
    /// @author Hanzalah Ravat
    public class WeaponManager : NetworkBehaviour
    {
        /// <summary>
        /// The Weapon that is currently equipped. Synced based on calls to SwitchWeapon
        /// </summary>
        [SyncVar (hook = nameof(SwitchWeapon))]
        public GameObject Weapon;
        /// <summary>
        /// The Enemy Layer
        /// </summary>
        public LayerMask EnemyLayer;

        /// <summary>
        /// Equippable Weapons in a List
        /// </summary>
        public List<GameObject> WeaponInventory;

        public Player ThisPlayer;

        private GameObject _weapon;


        public void SwitchWeapon(GameObject oldWeapon, GameObject newWeapon)
        {
            StartCoroutine(ChangeWeapon(newWeapon));
        }

        public void SayHellow()
        {
            Debug.Log("HELLOW");
        }

        private IEnumerator ChangeWeapon(GameObject newWeapon)
        {
            // Destroy Current Weapon
            while (Weapon.transform.childCount > 0)
            {
                Destroy(Weapon.transform.GetChild(0).gameObject);
                yield return null;
            }
            // Instantiate new weapon
            Instantiate(newWeapon, Weapon.transform);
            _weapon = newWeapon;
            //TODO Weapon instantiation code to be added here
        }

        void Update()
        {
            if (!isLocalPlayer)
                return;
            //Check keypress actions on Mobile and Desktop here.
            #if UNITY_STANDALONE || UNITY_WEBPLAYER
            // Desktop Build so use key inputs.
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SwitchWeapon(_weapon,WeaponInventory[0]);
                Debug.Log("Weapon Swap Invoked. Swap to Baton");
            } else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                SwitchWeapon(_weapon,WeaponInventory[1]);
                Debug.Log("Weapon Swap Invoked. Swap to Gun");
            }
            #elif UNITY_IOS || UNITY_ANDROID || UNITY_WP8 || UNITY_IPHONE
            // TODO Implement Mobile Weapon Swap Controls
            #endif
        }
    }
}