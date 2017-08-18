using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableBehaviour : MonoBehaviour
{  
    public List<Entry> entryList  = new List<Entry>(0);

    /// <summary>
    /// Metodo para adicionar elemento na lista
    /// </summary>
    /// <param name="key">Recebe uma key</param>
    /// <param name="value">Recebe o valor</param>
    public void AddToList(string key, int value)
    {
        Entry entry = new Entry();
        entry.key = key;
        entry.value = value;
        entryList.Add(entry);
    }

    /// <summary>
    /// Metodo para remover elemento da lsita
    /// </summary>
    /// <param name="index">Recebe o indice do elemento</param>
    public void RemoveFromList(int index)
    {
        entryList.RemoveAt(index);
    }
}

/// <summary>
/// Classe Entry para os dados
/// </summary>
public class Entry
{
    public string key;
    public int value;
}
