using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

/* Contains tools for txt.file management
 */
public class TxtTools{

    /**
     * Kirjoittaa jotakin johonkin tekstitiedostoon, joka sijaitsee ohjelman Assets-kansiossa.
     * 
     * @param tiedosto tiedoston nimi, johon halutaan kirjoittaa
     * @param teksti se teksti, mikä tiedostoon halutaan kirjoittaa
     */
    public void kirjoitaTiedostoon(string tiedosto, string teksti)
    {
        string path = "Assets/" + tiedosto + ".txt";

        StreamWriter writer = new StreamWriter(path, true);
        writer.Write(teksti);
        writer.Close();
    }

    /**
     * Poistaa tekstitiedoston koko sisällön.
     * 
     * @param tiedosto se tiedosto, jonka sisältö halutaan poistaa
     */
    public void poistaTiedostosta(string tiedosto)
    {
        string path = "Assets/" + tiedosto + ".txt";
        File.WriteAllText(path, string.Empty);
    }

    /**
    * Lukee tulostukseen jonkin tekstitiedoston, joka sijaitsee ohjelman Assets-kansiossa.
    * 
    * @param tiedosto tiedoston nimi, joka halutaan lukea.
    */
    public void lueTiedostosta(string tiedosto)
    {
        string path = "Assets/" + tiedosto + ".txt";
    
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

    /**
     * Palauttaa tekstitiedoston sisällön merkkijonona.
     * 
     * @param tiedosto se tiedosto, jonka teksti halutaan palauttaa.
     */
    public string annaTeksti(string completePath)
    {
        //string path = "Assets/" + tiedosto + ".txt";

        StreamReader reader = new StreamReader(completePath);
        string sisalto = reader.ReadToEnd();
        reader.Close();
        return sisalto;
    }
}


