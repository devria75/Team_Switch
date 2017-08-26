using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Absorb_Suck : MonoBehaviour
{
    void FixedUpdate()
    {
        TeamMember tm = GetComponent<TeamMember>();
        TeamMember myTm = this.GetComponent<TeamMember>();

            if (Input.GetButtonDown("Fire1"))
            {
            if (tm.teamID == 0 || myTm.teamID == 0 || tm.teamID != myTm.teamID)
            {
                Vector3 fwd = transform.TransformDirection(Vector3.forward);

                if (Physics.Raycast(transform.position, fwd, 10))
                    print("You're hitting stuff!");
            }
            }

        }
    }                                                                                   