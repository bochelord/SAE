using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Threading;
using System.Threading.Tasks;

public class ColumnAnimArena2 : MonoBehaviour
{

    public GameObject Column;
    public GameObject Column2;

    private void Start()
    {
        AnimateColumn();
    }

    public async void AnimateColumn()
    {
        print("reached");
        await Task.Delay(1000);

        Column.transform.DOMoveY(Column.transform.position.y + 30f, 4.5f).SetEase(Ease.InOutQuad).OnComplete(()=> {
            Column2.transform.DOMoveY(Column2.transform.position.y + 30f, 3f).SetEase(Ease.InOutQuad);
        });
    }

}
