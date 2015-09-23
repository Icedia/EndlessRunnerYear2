using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class obstacleManagement : MonoBehaviour {

    public GameObject obstaclePrefab;

    private List<GameObject> _obstacles;
    private int _minimalSpawnCooldown = 5;
    private int _maxObstacles = 2;

	void Start () {
	    _obstacles = new List<GameObject>();
	}

    private GameObject newObstacle() {
        GameObject obj = Instantiate(obstaclePrefab, new Vector3(100,0), Quaternion.identity) as GameObject;
        return obj;
    }

	void Update () {
        for (int i = 0; i < _obstacles.Count; i++) {
            GameObject obj = _obstacles[i] as GameObject;
            Vector3 pos = obj.transform.position;
            obj.transform.position = new Vector3(pos.x - 0.1f, 0);
            if (pos.x <= -100) {
                _obstacles.Remove(obj);
                Destroy(obj);
            }
        }

        if (_obstacles.Count < _maxObstacles) {
            _obstacles.Add(newObstacle());
        }
	}
}
