using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DampedSpring : MonoBehaviour
{
    public struct DampedSpringParameters
    {
        /// <summary>
        /// The current lenght
        /// </summary>  
        public float p;
        /// <summary>
        /// The mass of the attached weight
        /// </summary>
        public float mass;
        /// <summary>
        /// The dampening force
        /// </summary>
        public float beta; 
        /// <summary>
        /// Spring constant
        /// </summary>
        public float k;
        /// <summary>
        /// Resting length
        /// </summary>
        public float r;

        public float deltaTime; 
    }
    void DampedSpringMotion(DampedSpringParameters parameters)
    {
        /// <summary>
        /// damping ratio
        /// </summary>
        float zeta = parameters.beta / (2 * Mathf.Sqrt(parameters.mass * parameters.k));

        if(zeta > 1)
        {
            //over-damped

        }
    }
    void Update()
    {
        
    }
}
