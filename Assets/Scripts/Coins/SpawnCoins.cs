using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject coinsPool;
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }
    public IEnumerator Spawn()
    {
        yield return new WaitForSeconds(3);
        GameObject coin = coinsPool.GetComponent<CoinsPool>().GetPooledObject();
        if (coin != null)
        {
            //alta pantalla -9.17 -0.81 y baja pantalla 9.23 -2.83
            x = Random.Range(-9.17f, 9.23f);
            y = Random.Range(-.81f, -2.83f);
            coin.transform.position = new Vector3(x, y, 0);
            coin.SetActive(true);
        }
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
