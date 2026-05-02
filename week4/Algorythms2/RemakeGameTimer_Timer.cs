using System;
using Unity.VisualScripting;
using UnityEngine;

//with feedback.

public class RemakeGameTimer_Timer : MonoBehaviour
{
    bool temporizadorActivo; // 1 dependencia
    bool musicaBackground; // 1 dependencia
    int tiempoRestante; // valor no escalable
    bool respawnEnCasa; // dependencias ?
    public RemakeGameTimer_Sword scriptEspada;
    float timerInterno = 0f; 
 
    void Start()
    {
        temporizadorActivo = false;
        musicaBackground = false;
        tiempoRestante = 59;
        respawnEnCasa = false;
    }

    void Update()
    {
        if (!temporizadorActivo && (scriptEspada.EsRecogida() || respawnEnCasa))
        {  /*  resolution logic 
        1- Luego de start all values, lee line 30, solves the parentesis 2-y compara con la primera condición de TemporizadorActivo. 
        3- runs line 34, then runs method ActivarTemporizador and runs the method from line 57 to 62. */
            
            ActivarTemporizador();  
        }

        if (temporizadorActivo) 
        { 
        timerInterno += Time.deltaTime; // cada segundo en unity se acumula y se suma automaticamente dentro de la variable timerInterno.

        if (timerInterno >= 1f)     // cada vez que llegue a 1 segundo 
        {                           // logica del Update x frame 
            timerInterno = 0f;      // reinicia el acumulador
            tiempoRestante--;       // El timerInterno acumula segundos y tiempoRestante resta -1, el que arranca en 59.
            timeTriggers();         // runs method TimeTriggers.
        }
        }
    }

    void ActivarTemporizador()
    {
        temporizadorActivo = true;
        tiempoRestante = 59;
        timerInterno = 0f;
    }

    void timeTriggers()
    {
        if(tiempoRestante == 10) iniciarAnimacionAlerta();
        if(tiempoRestante == 9)  iniciarRitmoDecreciente1();
        if(tiempoRestante == 3)  iniciarRitmoDecreciente2();
        if(tiempoRestante == 0)
            {
                 temporizadorActivo = false;
                 BloquearControles();
                 ReproducirSonidoFinal();
                 ReproducirAnimacionFinal();
                 RespawnEnCasa();
            }
    }

    //Optimized Alternative
    //-> UnityEvents , un manager que sea el timer, singleton que lo lea el game manager, el gamemanager suscribe eventos con keys de tiempo al time manager , el time manager lee los eventos y los ejecuta

}
        
