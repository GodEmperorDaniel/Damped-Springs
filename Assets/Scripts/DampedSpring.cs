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
    }
    void DampedSpringMotion(DampedSpringParameters parameters)
    {
        
    }
    void Update()
    {
        
    }
}
