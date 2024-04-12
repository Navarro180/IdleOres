using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SteminaController : MonoBehaviour
{
    [Header("Stemina Main Parameters")]
    public float _playerStemina = 100f;
    [SerializeField] private float _maxStemina = 100f;
    [SerializeField] private bool _hasRegenerated = true;
    [SerializeField] private bool _weAreMoving = false;
}
