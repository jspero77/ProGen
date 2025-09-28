using UnityEngine;

public class ProGen : MonoBehaviour
{

    public int width;
    public GameObject dirt,grass;
    public int height;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Gen();
    }

    // Update is called once per frame
    void Gen()
    {
        for (int x = 0; x < width; x++)
        {
            int minHeight = height - 1;
            int maxHeight = height + 2;

            height = Random.Range(minHeight, maxHeight);
            for (int y = 0; y < height; y++)
            {
                
                spawnObject(dirt, x, y);
            }
            spawnObject(grass, x, height);
        }
 
    }

    void spawnObject(GameObject obj, int width, int height)
    {
obj = Instantiate(obj, new Vector2(width, height), Quaternion.identity);
        obj.transform.parent = this.transform;
    }
}
