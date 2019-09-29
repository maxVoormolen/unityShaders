using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Food : MonoBehaviour
{
    [SerializeField]
    private GameObject _food;
    private int _cooldown;

    void Update()
    {
        _cooldown--;
        if (_cooldown <= 0)
        {
            int r = Random.Range(-3, 5);
            Vector3 spawnPoint = new Vector3(r, this.gameObject.transform.position.y, 0);
            Instantiate(_food, spawnPoint, Quaternion.identity);
            _cooldown = 40;
        }
    }
}
