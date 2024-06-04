using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class QuizManager : MonoBehaviour
{
    public SaveManager saveManager;
    public GameManager gameManager;

    public DetectImageQuiz detectImageQuiz;
    public TextMeshProUGUI correctorIncorrectText;

   // public GameObject quizPanel;
    public TextMeshProUGUI _questionText;
    public Button[] optionButtons;

    private List<string> questions;
    private List<List<string>> options;
    private List<int> correctAnswers;
    private int currentQuestionIndex;


    public TextMeshProUGUI timerText;
    public float interval = 60f;

    private float timer = 60f;



    public string star_1_cooldown;
    public string[] star_cooldownValues = new string[100];


    public string AnsweredOrNot;








    private List<List<string>> questionsPools = new List<List<string>>();
    private List<List<List<string>>> optionsPools = new List<List<List<string>>>();
    private List<List<int>> correctAnswersPools = new List<List<int>>();




    public int[] arrayQuestionIndex = new int[50];


    void Start()
    {
        //   quizPanel.SetActive(false); // Quiz panel is initially disabled










        InitializeQuizPools();

        InitializeQuiz();


        OpenQuizPanel(0,0);

        for (int i = 0; i < 3; i++)
        {
            OpenQuizPanel(i,0);
        }



        RandomizeArray();



        InvokeRepeating(nameof(CallFunction), interval, interval);

        // Start the coroutine to update the timer text
        StartCoroutine(UpdateTimer());

        for (int i = 0; i < star_cooldownValues.Length; i++)
        {
            star_cooldownValues[i] = "Ready";
        }


        star_1_cooldown = "Ready";

        UpdateStarVisibility();


   

}









    void RandomizeArray()
    {
        for (int i = 0; i < arrayQuestionIndex.Length; i++)
        {
            // Generate a random number between 0 and 3 (inclusive)
            arrayQuestionIndex[i] = Random.Range(0, 3);
        }
    }













    void CallFunction()
    {
        // Call your function here
        Debug.Log("Function called!");
        OpenQuizPanel(0,0);
        for (int i = 0; i < 3; i++)
        {
            OpenQuizPanel(i,0);
        }

    }

    // Coroutine to update the timer text             
    IEnumerator UpdateTimer()
    {
        while (true)
        {
            // Wait for one second
            yield return new WaitForSeconds(1f);

            // Decrement the timer
            timer -= 1f;

            // Check if the timer has reached 0
            if (timer <= 0f)
            {
                // Reset the timer back to the interval value
                timer = interval;

                // Call your function here when timer reaches 0
                Debug.Log("Function called!");
                // OpenQuizPanel(1);





             //   OpenQuizPanel(0);
                for (int i = 0; i < 3; i++)
                {
                   // OpenQuizPanel(i);
                    ShuffleQuestionsAndOptions(i);
                }


                RandomizeArray();
                //  star_1_cooldown = "Ready";



                for (int i = 0; i < star_cooldownValues.Length; i++)
                {
                    star_cooldownValues[i] = "Ready";
                }

            }

            // Update the timer text
            UpdateTimerText();

        }
    }

    // Update the timer text
    void UpdateTimerText()
    {
        // Convert timer to minutes and seconds
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);

        // Update the timer text
        timerText.text = "Reset: "+string.Format("{0:00}:{1:00}", minutes, seconds);
    }








    /*
 * 
 * 
 * �D�nde pones tu ropa limpia?
a) La cocina
b) El ba�o
c) El armario

�Qu� usas para dormir?
a) El frigor�fico
b) La cama
c) La mesa

�D�nde te ba�as?
a) La cocina
b) El ba�o
c) El garaje

�D�nde guardas tus libros?
a) El armario
b) La nevera
c) La lavadora

�D�nde te sientas a comer?
a) El jard�n
b) El sof�
c) La mesa

Answers:

c) El armario
b) La cama
b) El ba�o
a) El armario
c) La mesa
 * 
 * 
 * 
 * 
 * I want to use 5 rnadom questions for this gameobject, but i want to reuse this script in different gameobject using different set of 5 random questions. can i pass parameter from each gameobject to pick speicfic set of 5 questions


 * 
 */










    void InitializeQuizPools()
    {
        // Define questions, options, and correct answers for each pool
        // Pool 1
        List<string> questionsPool1 = new List<string>()
        {
            "�D�nde pones tu ropa limpia?",
            "�Qu� usas para dormir?",
            "�D�nde te sientas a comer?",
            "�D�nde guardas tus libros?",
            // Add more questions...
        };

        List<List<string>> optionsPool1 = new List<List<string>>()
        {
            new List<string>() { "El armario", "La cocina", "El ba�o", "La sala" },
            new List<string>() { "La cama", "El frigor�fico", "La silla", "La mesa" },
            new List<string>() { "La mesa", "El sof�", "El jard�n", "El ba�o" },
            new List<string>() { "El armario", "La nevera", "El jard�n", "El ba�o" },
            // Add more options...
        };

        List<int> correctAnswersPool1 = new List<int>() { 0, 0 ,0,0}; // Index of correct answers for each question

        // Pool 2
        List<string> questionsPool2 = new List<string>()
{
    "�D�nde colocas tu televisor?",
    "�Qu� usas para sentarte frente al escritorio?",
    "�D�nde guardas tu ropa interior?",
    "�Qu� usas para descansar en la sala de estar?",
    // Add more questions...
};

        List<List<string>> optionsPool2 = new List<List<string>>()
{
    new List<string>() { "El mueble de la televisi�n", "La cocina", "El ba�o", "El armario" },
    new List<string>() { "La silla", "El refrigerador", "El escritorio", "La mesa" },
    new List<string>() { "El armario", "La mesa de noche", "El ba�o", "El caj�n" },
    new List<string>() { "El sof�", "La nevera", "El jard�n", "El ba�o" },
    // Add more options...
};

        List<int> correctAnswersPool2 = new List<int>() { 0, 0,0,0 }; // Index of correct answers for each question
                                                                  // Pool 2
        List<string> questionsPool3 = new List<string>()
{
    "�D�nde plantas flores y vegetales?",
    "�Qu� usas para relajarte al aire libre?",
    "�D�nde guardas tus herramientas de jardiner�a?",
    "�Qu� usas para asar carne y verduras?",
    // Add more questions...
};

        List<List<string>> optionsPool3 = new List<List<string>>()
{
    new List<string>() { "El jard�n", "La sala de estar", "El balc�n", "El armario" },
    new List<string>() { "La hamaca", "El columpio", "La cama", "La silla" },
    new List<string>() { "El cobertizo", "La cocina", "El s�tano", "El �tico" },
    new List<string>() { "La parrilla", "El microondas", "La estufa", "La barbacoa" },
    // Add more options...
};

        List<int> correctAnswersPool3 = new List<int>() { 0, 0,0,0 }; // Index of correct answers for each question








        List<string> questionsPool4 = new List<string>()
{
    "�Qui�n es el abuelo de tu madre?",
    "�Qui�n es la persona que es hijo de tu t�o?",
    "�Qui�n es la hija de tu hermana?",
    "�Qui�n da a luz al beb�?",
    // Add more questions...
};

        List<List<string>> optionsPool4 = new List<List<string>>()
{
    new List<string>() { "Abuelo materno", "T�o paterno", "Primo", "Padrino" },
    new List<string>() { "Primo", "Hermano", "Sobrino", "Padrino" },
    new List<string>() { "Sobrina", "Prima", "Nieto", "T�a" },
    new List<string>() { "Madre", "Padre", "Abuela", "Hermana" },

    // Add corresponding options for each question...
};

        List<int> correctAnswersPool4 = new List<int>() { 0,0,0,0 };

        List<string> questionsPool5 = new List<string>()
{
    "�D�nde se almacena el agua caliente en la casa?",
    "�Qu� usas para encender las luces en la noche?",
    "�D�nde se deposita la basura dom�stica antes de sacarla?",
    "�Qu� usas para mantener frescos los alimentos en la cocina?",
    // Add more questions...
};

        List<List<string>> optionsPool5 = new List<List<string>>()
{
    new List<string>() { "El calentador de agua", "La lavadora", "La nevera", "La ducha" },
    new List<string>() { "El interruptor de luz", "El horno", "El secador de pelo", "El reloj de pared" },
    new List<string>() { "El cubo de basura", "El frigor�fico", "La cama", "La mesa de noche" },
    new List<string>() { "El refrigerador", "El microondas", "El lavavajillas", "El televisor" },
    // Add more options...
};

        List<int> correctAnswersPool5 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        //////////////
        ///
        List<string> questionsPool6 = new List<string>()
{
    "�Qu� colocas en las ventanas para bloquear la luz del sol?",
    "�Qu� elemento decorativo suele colocarse en las mesas para embellecer el espacio?",
    "�Qu� objetos se utilizan para iluminar una habitaci�n de forma rom�ntica?",
    "�Qu� elementos se usan para agregar un toque de color a las habitaciones?",
    // Add more questions...
};

        List<List<string>> optionsPool6 = new List<List<string>>()
{
    new List<string>() { "Las cortinas", "Los cojines", "Los espejos", "Los floreros" },
    new List<string>() { "Las velas", "Los electrodom�sticos", "Los platos", "Los cubiertos" },
    new List<string>() { "Las velas", "Los libros", "Los juguetes", "Los marcos de fotos" },
    new List<string>() { "Las almohadas", "Los muebles", "Las toallas", "Las plantas" },
    // Add more options...
};

        List<int> correctAnswersPool6 = new List<int>() { 0, 0, 0, 0 };


        List<string> questionsPool7 = new List<string>()
{
    "�Qu� necesitas para tapar agujeros en las paredes?",
    "�Qu� herramienta utilizas para apretar tornillos sueltos?",
    "�Qu� producto se utiliza para sellar grietas en las ventanas?",
    "�Qu� material se usa para reparar tuber�as con fugas?",
    // Add more questions...
};

        List<List<string>> optionsPool7 = new List<List<string>>()
{
    new List<string>() { "La masilla", "La cinta adhesiva", "El yeso", "La pintura" },
    new List<string>() { "El destornillador", "El martillo", "La llave inglesa", "La sierra" },
    new List<string>() { "El silicona", "La cera", "El cemento", "La arcilla" },
    new List<string>() { "El cinta de fontanero", "La manguera", "La cinta aislante", "La cinta m�trica" },
    // Add more options...
};


        List<int> correctAnswersPool7 = new List<int>() { 0, 2, 0, 0 };








        List<string> questionsPool8 = new List<string>()
{
    "�Qu� sueles comprar para limpiar el suelo de tu casa?",
    "�Qu� art�culo compras para mantener frescos tus alimentos en la nevera?",
    "�Qu� producto sueles adquirir para lavar la ropa?",
    "�Qu� necesitas comprar para reponer el papel higi�nico en el ba�o?",
    // Add more questions...
};

        List<List<string>> optionsPool8 = new List<List<string>>()
{
    new List<string>() { "El detergente", "El perfume", "El jab�n de manos", "El desodorante" },
    new List<string>() { "El refrigerador", "La leche", "La bolsa de basura", "El microondas" },
    new List<string>() { "El detergente para ropa", "El champ�", "El aceite de cocina", "El desinfectante" },
    new List<string>() { "El papel higi�nico", "El champ�", "La pasta de dientes", "El gel de ducha" },
    // Add more options...
};

        List<int> correctAnswersPool8 = new List<int>() { 0, 0, 0, 0 };





        List<string> questionsPool9 = new List<string>()
{
    "�Qu� prendas se utilizan para cubrir las piernas?",
    "�Qu� tipo de ropa se usa para protegerse del fr�o en invierno?",
    "�Qu� prenda se usa para cubrir la parte superior del cuerpo?",
    "�Qu� accesorio se utiliza para cubrir la cabeza y protegerse del sol?",
};

        List<List<string>> optionsPool9 = new List<List<string>>()
{
    new List<string>() { "Camisetas", "Pantalones", "Sombreros", "Bufandas" },
    new List<string>() { "Sandalias", "Chaquetas", "Camisetas", "Faldas" },
    new List<string>() { "Calcetines", "Blusas", "Pantalones cortos", "Guantes" },
    new List<string>() { "Bufandas", "Sombreros", "Gafas de sol", "Relojes" },
};

        List<int> correctAnswersPool9 = new List<int>() { 1, 1, 1, 1 }; // Index of correct answers for each question


        List<string> questionsPool10 = new List<string>()
{
    "�Qu� tipo de alimento se obtiene de las vacas?",
    "�Qu� alimento se suele comer como plato principal en la cena?",
    "�Qu� fruta es conocida por ser amarilla y alargada?",
    "�Qu� bebida se obtiene del caf� molido y el agua caliente?",
};

        List<List<string>> optionsPool10 = new List<List<string>>()
{
    new List<string>() { "Leche", "Pan", "Pollo", "Arroz" },
    new List<string>() { "Pescado", "Ensalada", "Pasta", "Sopa" },
    new List<string>() { "Manzana", "Pl�tano", "Fresa", "Uva" },
    new List<string>() { "T�", "Zumo de naranja", "Refresco", "Caf�" },
};

        List<int> correctAnswersPool10 = new List<int>() { 0, 2, 1, 3 };



        List<string> questionsPool11 = new List<string>()
{
    "�Qu� tipo de juguete se utiliza para construir diferentes estructuras?",
    "�Qu� tipo de juguete se utiliza para jugar en el agua?",
    "�Qu� tipo de juguete se utiliza para jugar en la arena?",
    "�Qu� tipo de juguete se utiliza para jugar a lanzar y atrapar?",
};

        List<List<string>> optionsPool11 = new List<List<string>>()
{
    new List<string>() { "Bloques de construcci�n", "Mu�ecas", "Rompecabezas", "Instrumentos musicales" },
    new List<string>() { "Barcos", "Pelotas", "Mu�ecos de acci�n", "Puzzle" },
    new List<string>() { "Pala y cubo", "Aviones de juguete", "Peluches", "Patines" },
    new List<string>() { "Pelotas", "Coches", "Libros", "Cometas" },
};

        List<int> correctAnswersPool11 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question


        List<string> questionsPool12 = new List<string>()
{
    "�Qu� tipo de moneda se utiliza en los Estados Unidos?",
    "�Qu� billete tiene el mayor valor en la moneda de euros?",
    "�Qu� t�rmino se utiliza para referirse a la moneda en forma de metal?",
    "�Qu� se utiliza para realizar transacciones electr�nicas de dinero?",
};

        List<List<string>> optionsPool12 = new List<List<string>>()
{
    new List<string>() { "D�lar", "Euro", "Libra esterlina", "Yen" },
    new List<string>() { "500 euros", "200 euros", "100 euros", "50 euros" },
    new List<string>() { "Monedas", "Billetes", "Cheques", "Tarjetas de cr�dito" },
    new List<string>() { "Tarjeta de d�bito", "Transferencia bancaria", "PayPal", "Cheque" },
};

        List<int> correctAnswersPool12 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question


        List<string> questionsPool13 = new List<string>()
{
    "�D�nde puedes obtener informaci�n sobre los productos y servicios de una empresa?",
    "�Qu� t�rmino se utiliza para describir a una persona que compra productos o servicios de una empresa?",
    "�Qu� es importante para mantener satisfechos a los clientes?",
    "�Qu� se utiliza para medir la satisfacci�n del cliente con los productos o servicios?",
};

        List<List<string>> optionsPool13 = new List<List<string>>()
{
    new List<string>() { "P�gina web", "Redes sociales", "Tienda f�sica", "Correo electr�nico" },
    new List<string>() { "Cliente", "Vendedor", "Empleado", "Gerente" },
    new List<string>() { "Calidad", "Precio alto", "Servicio deficiente", "Producto inestable" },
    new List<string>() { "Encuestas", "Cartas", "Facturas", "Recibos" },
};

        List<int> correctAnswersPool13 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question

        List<string> questionsPool14 = new List<string>()
{
    "�Qu� celebramos el 14 de febrero?",
    "�Qu� festividad se celebra el 25 de diciembre?",
    "�Qu� evento se celebra cuando una persona cumple un a�o m�s de vida?",
    "�Qu� celebramos el 31 de diciembre para dar la bienvenida al nuevo a�o?",
};

        List<List<string>> optionsPool14 = new List<List<string>>()
{
    new List<string>() { "San Valent�n", "Navidad", "Cumplea�os", "A�o Nuevo" },
    new List<string>() { "Navidad", "San Valent�n", "Halloween", "D�a de Acci�n de Gracias" },
    new List<string>() { "Cumplea�os", "Navidad", "Halloween", "D�a de Acci�n de Gracias" },
    new List<string>() { "A�o Nuevo", "San Valent�n", "Halloween", "D�a de Acci�n de Gracias" },
};

        List<int> correctAnswersPool14 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question

        List<string> questionsPool15 = new List<string>()
{
    "�Cu�l es el r�o m�s largo del mundo?",
    "�En qu� pa�s se encuentra la Torre Eiffel?",
    "�Cu�l es la capital de Australia?",
    "�D�nde se encuentra la Gran Muralla China?",
};

        List<List<string>> optionsPool15 = new List<List<string>>()
{
    new List<string>() { "El Nilo", "El Amazonas", "El Misisipi", "El Yangts�" },
    new List<string>() { "Francia", "Italia", "Alemania", "Espa�a" },
    new List<string>() { "Camberra", "S�dney", "Melbourne", "Brisbane" },
    new List<string>() { "China", "India", "Jap�n", "Corea del Sur" },
};

        List<int> correctAnswersPool15 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question

        List<string> questionsPool16 = new List<string>()
{
    "�Qu� pa�s es conocido por su danza del tango?",
    "�Qui�n escribi� la famosa obra 'Don Quijote de la Mancha'?",
    "�Cu�l es la bebida nacional de Jap�n?",
    "�En qu� pa�s se origin� el flamenco?",
};

        List<List<string>> optionsPool16 = new List<List<string>>()
{
    new List<string>() { "Argentina", "Brasil", "Espa�a", "M�xico" },
    new List<string>() { "Miguel de Cervantes", "Federico Garc�a Lorca", "Pablo Neruda", "Gabriel Garc�a M�rquez" },
    new List<string>() { "Sake", "T�", "Caf�", "Vino" },
    new List<string>() { "Espa�a", "Portugal", "Francia", "Italia" },
};

        List<int> correctAnswersPool16 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question


        List<string> questionsPool17 = new List<string>()
{
    "�Qu� animal es conocido por su larga trompa?",
    "�Qu� tipo de animal es el le�n?",
    "�Cu�l es el �rbol m�s grande del mundo?",
    "�Qu� animal vuela m�s alto que otros?",
};

        List<List<string>> optionsPool17 = new List<List<string>>()
{
    new List<string>() { "Elefante", "Jirafa", "Hipop�tamo", "Le�n" },
    new List<string>() { "Mam�fero", "Reptil", "Ave", "Anfibio" },
    new List<string>() { "Secuoya", "Roble", "Pino", "Chopo" },
    new List<string>() { "�guila", "Buitre", "Cuervo", "B�ho" },
};

        List<int> correctAnswersPool17 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question


        List<string> questionsPool18 = new List<string>()
{
    "�Qui�n fue el primer presidente de Estados Unidos?",
    "�En qu� a�o comenz� la Primera Guerra Mundial?",
    "�Cu�l fue la capital del Imperio Romano?",
    "�Qui�n escribi� 'Don Quijote de la Mancha'?",
};

        List<List<string>> optionsPool18 = new List<List<string>>()
{
    new List<string>() { "George Washington", "Abraham Lincoln", "Thomas Jefferson", "John Adams" },
    new List<string>() { "1914", "1918", "1939", "1945" },
    new List<string>() { "Roma", "Atenas", "Alejandr�a", "Cartago" },
    new List<string>() { "Miguel de Cervantes", "Gabriel Garc�a M�rquez", "Pablo Neruda", "Federico Garc�a Lorca" },
};

        List<int> correctAnswersPool18 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool19 = new List<string>()
{
    "�Cu�l es un pasatiempo com�n que implica pintar sobre lienzo?",
    "�Qu� actividad implica la manipulaci�n de agujas e hilos para crear prendas de vestir?",
    "�Qu� deporte se juega en un campo con hoyos y palos?",
    "�Qu� actividad implica seguir un conjunto de instrucciones paso a paso para crear un objeto?"
};

        List<List<string>> optionsPool19 = new List<List<string>>()
{
    new List<string>() { "Pintura", "Escultura", "Cocina", "Canto" },
    new List<string>() { "Tejer", "Carpinter�a", "Jardiner�a", "Cer�mica" },
    new List<string>() { "Golf", "F�tbol", "Baloncesto", "Tenis" },
    new List<string>() { "Manualidades", "Ciclismo", "Escalada", "Nataci�n" }
};

        List<int> correctAnswersPool19 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool20 = new List<string>()
{
    "�Qu� utensilio se utiliza para remover alimentos en una sart�n caliente?",
    "�Qu� t�cnica implica cocinar los alimentos sumergi�ndolos en agua hirviendo?",
    "�Qu� m�todo de cocci�n utiliza calor seco en un horno?",
    "�Qu� ingrediente com�nmente se agrega a los platos para mejorar su sabor?"
};

        List<List<string>> optionsPool20 = new List<List<string>>()
{
    new List<string>() { "Esp�tula", "Tenedor", "Cuchillo", "Cuchara" },
    new List<string>() { "Hervir", "Fre�r", "Asar", "Saltear" },
    new List<string>() { "Asar", "Hervir", "Fre�r", "Saltear" },
    new List<string>() { "Sal", "Az�car", "Vinagre", "Aceite" }
};

        List<int> correctAnswersPool20 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool21 = new List<string>()
{
    "�Qu� tipo de lugar tur�stico suele ser menos conocido pero igualmente encantador?",
    "�D�nde puedes encontrar atracciones tur�sticas no tan populares pero interesantes?",
    "�Qu� se entiende por 'tesoro escondido' en el contexto de viajes?",
    "�D�nde pueden los viajeros descubrir lugares �nicos y aut�nticos fuera de los destinos tur�sticos habituales?"
};

        List<List<string>> optionsPool21 = new List<List<string>>()
{
    new List<string>() { "Lugares secretos", "Lugares famosos", "Lugares concurridos", "Lugares comerciales" },
    new List<string>() { "Ciudades menos conocidas", "Ciudades capitales", "Ciudades tur�sticas", "Ciudades grandes" },
    new List<string>() { "Un lugar poco conocido pero especial", "Un lugar aburrido", "Un lugar peligroso", "Un lugar peque�o" },
    new List<string>() { "Pueblos remotos", "Centros urbanos", "�reas metropolitanas", "Resorts de lujo" }
};

        List<int> correctAnswersPool21 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question


        List<string> questionsPool22 = new List<string>()
{
    "�Qu� actividad f�sica implica esfuerzo muscular repetitivo y aumenta la resistencia cardiovascular?",
    "�Qu� tipo de ejercicio se centra en el desarrollo de la fuerza y la resistencia muscular?",
    "�Qu� pr�ctica f�sica implica estiramientos y posturas para mejorar la flexibilidad y el equilibrio?",
    "�Qu� forma de entrenamiento se enfoca en mejorar la coordinaci�n, la agilidad y la velocidad?"
};

        List<List<string>> optionsPool22 = new List<List<string>>()
{
    new List<string>() { "Cardio", "Yoga", "Pilates", "Tai Chi" },
    new List<string>() { "Entrenamiento de fuerza", "Nataci�n", "Ciclismo", "Caminata" },
    new List<string>() { "Yoga", "Entrenamiento de fuerza", "Pilates", "Ciclismo" },
    new List<string>() { "Entrenamiento de agilidad", "Nataci�n", "Caminata", "Tai Chi" }
};

        List<int> correctAnswersPool22 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question

        List<string> questionsPool23 = new List<string>()
{
    "�Qu� grupo de alimentos es una fuente importante de energ�a y proporciona carbohidratos?",
    "�Qu� grupo de alimentos es rico en prote�nas y es esencial para el crecimiento muscular?",
    "�Qu� grupo de alimentos es una fuente clave de vitaminas y minerales para una buena salud?",
    "�Qu� grupo de alimentos es rico en grasas saludables y es beneficioso para la salud del coraz�n?"
};

        List<List<string>> optionsPool23 = new List<List<string>>()
{
    new List<string>() { "Los carbohidratos", "Las grasas", "Las prote�nas", "Las vitaminas" },
    new List<string>() { "Las prote�nas", "Los carbohidratos", "Las frutas", "Los l�cteos" },
    new List<string>() { "Las frutas y verduras", "Las grasas", "Las prote�nas", "Los carbohidratos" },
    new List<string>() { "Las grasas saludables", "Las prote�nas", "Los l�cteos", "Las frutas" }
};

        List<int> correctAnswersPool23 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool24 = new List<string>()
{
    "�Qu� pr�ctica se centra en el desarrollo de habilidades para manejar el estr�s y la ansiedad?",
    "�Qu� actividad puede ayudar a mejorar el estado de �nimo y reducir el estr�s?",
    "�Qu� pr�ctica implica enfocar la atenci�n en el momento presente para aumentar la conciencia?",
    "�Qu� actividad fomenta la expresi�n de emociones y puede mejorar la salud mental?"
};

        List<List<string>> optionsPool24 = new List<List<string>>()
{
    new List<string>() { "La meditaci�n", "La lectura", "El ejercicio", "El trabajo" },
    new List<string>() { "El ejercicio", "La meditaci�n", "El trabajo", "La lectura" },
    new List<string>() { "La atenci�n plena (mindfulness)", "La meditaci�n", "La lectura", "El trabajo" },
    new List<string>() { "La terapia art�stica", "La meditaci�n", "La lectura", "El ejercicio" }
};

        List<int> correctAnswersPool24 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool25 = new List<string>()
{
    "�Qu� pr�ctica puede ayudar a mejorar la calidad del sue�o?",
    "�Qu� actividad puede contribuir a establecer una rutina de sue�o saludable?",
    "�Qu� entorno es propicio para un mejor descanso durante la noche?",
    "�Qu� h�bito puede interferir con un sue�o reparador?"
};

        List<List<string>> optionsPool25 = new List<List<string>>()
{
    new List<string>() { "La relajaci�n antes de acostarse", "La cafe�na antes de acostarse", "El ejercicio intenso antes de acostarse", "El trabajo antes de acostarse" },
    new List<string>() { "Mantener un horario regular de sue�o", "Ver televisi�n hasta tarde", "Trabajar hasta tarde en la computadora", "Tomar siestas largas durante el d�a" },
    new List<string>() { "Un entorno oscuro y tranquilo", "Un entorno ruidoso y brillante", "Un entorno con luz brillante", "Un entorno caliente y h�medo" },
    new List<string>() { "Mirar pantallas brillantes antes de acostarse", "Apagar los dispositivos electr�nicos antes de acostarse", "Leer un libro antes de acostarse", "Tomar una ducha caliente antes de acostarse" }
};

        List<int> correctAnswersPool25 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question

        List<string> questionsPool26 = new List<string>()
{
    "�Cu�l de las siguientes es una enfermedad contagiosa causada por un virus?",
    "�Cu�l de las siguientes enfermedades afecta principalmente al sistema respiratorio?",
    "�Cu�l de las siguientes enfermedades se transmite principalmente a trav�s de picaduras de mosquitos?",
    "�Cu�l de las siguientes enfermedades afecta al sistema inmunol�gico y no tiene cura conocida?"
};

        List<List<string>> optionsPool26 = new List<List<string>>()
{
    new List<string>() { "La gripe", "La diabetes", "La hipertensi�n", "El c�ncer" },
    new List<string>() { "El asma", "La diabetes", "La artritis", "La migra�a" },
    new List<string>() { "El dengue", "La diabetes", "La tuberculosis", "El VIH/SIDA" },
    new List<string>() { "El VIH/SIDA", "La diabetes", "La hipertensi�n", "El c�ncer" }
};

        List<int> correctAnswersPool26 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question




        List<string> questionsPool27 = new List<string>()
{
    "�Qu� cambios f�sicos son comunes durante el proceso de envejecimiento?",
    "�Cu�l es una pr�ctica saludable para promover el envejecimiento activo?",
    "�Qu� aspecto del cuidado de la piel es importante a medida que envejecemos?",
    "�Qu� h�bito puede ayudar a mantener la salud mental durante el envejecimiento?"
};

        List<List<string>> optionsPool27 = new List<List<string>>()
{
    new List<string>() { "P�rdida de elasticidad de la piel", "Aumento de la fuerza muscular", "Mayor densidad �sea", "Aumento de la agudeza visual" },
    new List<string>() { "Hacer ejercicio regularmente", "Permanecer sedentario la mayor parte del tiempo", "Evitar actividades sociales", "Consumir alimentos procesados" },
    new List<string>() { "La hidrataci�n adecuada", "La exposici�n prolongada al sol", "Fumar cigarrillos", "El uso irregular de protector solar" },
    new List<string>() { "Mantenerse mentalmente activo", "Aislarse socialmente", "Evitar desaf�os cognitivos", "Dormir demasiado" }
};

        List<int> correctAnswersPool27 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool28 = new List<string>()
{
    "�Cu�l de las siguientes actividades es una forma efectiva de mejorar la salud cardiovascular?",
    "�Cu�l de los siguientes ejercicios se enfoca en fortalecer los m�sculos abdominales?",
    "�Qu� tipo de ejercicio ayuda a mejorar la flexibilidad y reducir el estr�s?",
    "�Cu�l es una forma com�n de medir la intensidad del ejercicio?"
};

        List<List<string>> optionsPool28 = new List<List<string>>()
{
    new List<string>() { "Correr", "Ver televisi�n", "Sentarse por largos per�odos", "Comer alimentos grasos" },
    new List<string>() { "Las abdominales", "El yoga", "La nataci�n", "El ciclismo" },
    new List<string>() { "El yoga", "Levantamiento de pesas", "Correr", "Los estiramientos" },
    new List<string>() { "La frecuencia card�aca", "El n�mero de abdominales", "El tiempo de televisi�n", "El n�mero de calor�as consumidas" }
};

        List<int> correctAnswersPool28 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool29 = new List<string>()
{
    "�Cu�l es una estrategia efectiva para mejorar la retenci�n de informaci�n mientras estudias?",
    "�Qu� habilidad es fundamental para el aprendizaje efectivo?",
    "�Qu� tipo de recursos pueden ayudarte a comprender mejor un tema complejo?",
    "�Cu�l es una t�cnica �til para organizar tu tiempo de estudio?"
};

        List<List<string>> optionsPool29 = new List<List<string>>()
{
    new List<string>() { "Tomar notas", "Olvidar lo que has aprendido", "Estudiar en un entorno ruidoso", "No repasar material previamente aprendido" },
    new List<string>() { "La capacidad de concentraci�n", "La procrastinaci�n", "La distracci�n constante", "La falta de inter�s" },
    new List<string>() { "Libros, art�culos y videos", "Rumores y conjeturas", "Noticias falsas", "Chismes de amigos" },
    new List<string>() { "Crear un horario de estudio", "Dejar todo para el �ltimo minuto", "No planificar", "Estudiar todo de una sola vez" }
};

        List<int> correctAnswersPool29 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool30 = new List<string>()
{
    "�Qu� beneficios ofrece asistir a la universidad?",
    "�Cu�l es una parte importante de la experiencia universitaria m�s all� de la educaci�n formal?",
    "�Qu� tipo de actividades extracurriculares son comunes en la universidad?",
    "�Cu�l es una responsabilidad importante para los estudiantes universitarios?"
};

        List<List<string>> optionsPool30 = new List<List<string>>()
{
    new List<string>() { "Oportunidades de aprendizaje", "Perder el tiempo", "No ganar nada", "Estar desinformado" },
    new List<string>() { "La socializaci�n y el desarrollo personal", "El aislamiento y la soledad", "La falta de interacci�n", "No tener amigos" },
    new List<string>() { "Clubes, deportes y grupos estudiantiles", "Ver televisi�n todo el d�a", "Dormir en clase", "No participar en nada" },
    new List<string>() { "Tomar responsabilidad de su propio aprendizaje", "Depender completamente de los profesores", "No hacer las tareas", "No estudiar para los ex�menes" }
};

        List<int> correctAnswersPool30 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool31 = new List<string>()
{
    "�Qu� tipo de recursos puedes encontrar en una biblioteca?",
    "�Cu�l es el prop�sito principal de una biblioteca?",
    "�Qu� beneficios ofrece el uso de una biblioteca?",
    "�Qu� servicios adicionales suelen ofrecer las bibliotecas modernas?"
};

        List<List<string>> optionsPool31 = new List<List<string>>()
{
    new List<string>() { "Libros, revistas y peri�dicos", "Comida r�pida y bebidas", "Ropa y accesorios", "Juguetes y juegos" },
    new List<string>() { "Proporcionar acceso a la informaci�n y la educaci�n", "Vender productos electr�nicos", "Servir como lugar de entretenimiento", "Nada importante" },
    new List<string>() { "Acceso gratuito a una amplia gama de recursos", "Costo elevado y restricciones de acceso", "Ofrecer �nicamente libros aburridos", "No ofrecer nada" },
    new List<string>() { "Servicios de internet, salas de estudio y actividades culturales", "Servicios de lavander�a y comida r�pida", "Servicios de peluquer�a y spa", "No ofrecer ning�n servicio adicional" }
};

        List<int> correctAnswersPool31 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool32 = new List<string>()
{
    "�Qu� estrategias pueden ayudarte a prepararte para un examen?",
    "�Por qu� es importante leer las preguntas detenidamente durante un examen?",
    "�Qu� debes hacer si no est�s seguro de la respuesta a una pregunta durante un examen?",
    "�Qu� tipo de ambiente de estudio es m�s propicio para un rendimiento �ptimo en un examen?"
};

        List<List<string>> optionsPool32 = new List<List<string>>()
{
    new List<string>() { "Estudiar regularmente y repasar el material", "No estudiar en absoluto", "Esperar hasta el �ltimo minuto para estudiar", "Copiar las respuestas de otros" },
    new List<string>() { "Para comprender completamente lo que se pregunta", "Para ignorar las preguntas y adivinar las respuestas", "Para responder al azar", "Para no leer las preguntas" },
    new List<string>() { "Intentar responder la pregunta de la mejor manera posible", "Dejar la pregunta en blanco", "Adivinar aleatoriamente", "No hacer nada" },
    new List<string>() { "Un ambiente tranquilo y libre de distracciones", "Un ambiente ruidoso y ca�tico", "Un ambiente lleno de distracciones", "Un ambiente oscuro y sombr�o" }
};

        List<int> correctAnswersPool32 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool33 = new List<string>()
{
    "�Qu� actividades suelen llevarse a cabo durante una clase?",
    "�Cu�l es el prop�sito de asistir a clases?",
    "�Por qu� es importante participar activamente en clase?",
    "�Qu� beneficios puede proporcionar la interacci�n con otros estudiantes durante las clases?"
};

        List<List<string>> optionsPool33 = new List<List<string>>()
{
    new List<string>() { "Lectura, discusi�n y actividades pr�cticas", "Dormir y descansar", "Jugar y distraerse", "Hacer ejercicio f�sico" },
    new List<string>() { "Adquirir conocimientos y habilidades", "Perder el tiempo", "Socializar solo", "No hay ning�n prop�sito" },
    new List<string>() { "Para comprender mejor los conceptos y mejorar el aprendizaje", "Para ignorar la clase y distraerse", "Para molestar a otros estudiantes", "Para no prestar atenci�n" },
    new List<string>() { "Aprendizaje colaborativo y desarrollo de habilidades sociales", "Aislamiento y falta de interacci�n", "Competencia y rivalidad", "No hay ning�n beneficio" }
};

        List<int> correctAnswersPool33 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool34 = new List<string>()
{
    "�Cu�l es el papel del profesor en el proceso de ense�anza?",
    "�Qu� cualidades hacen que un buen profesor sea efectivo?",
    "�Por qu� es importante respetar al profesor?",
    "�C�mo puede un profesor motivar a sus estudiantes?"
};

        List<List<string>> optionsPool34 = new List<List<string>>()
{
    new List<string>() { "Facilitar el aprendizaje y guiar a los estudiantes", "Distractores y obst�culos para el aprendizaje", "No hacer nada", "Imponer castigos" },
    new List<string>() { "Conocimiento del tema, claridad y empat�a", "Ignorancia y desinter�s", "Falta de habilidades de comunicaci�n", "Mal genio y comportamiento inapropiado" },
    new List<string>() { "Porque el profesor merece respeto por su posici�n y conocimientos", "Porque el profesor no merece respeto", "Porque el respeto no importa", "Porque el profesor es un igual" },
    new List<string>() { "Ofreciendo retroalimentaci�n positiva y desafiando a los estudiantes", "Ignorando a los estudiantes y siendo negativo", "Desmotivando a los estudiantes", "No haciendo nada para motivar" }
};

        List<int> correctAnswersPool34 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool35 = new List<string>()
{
    "�Qu� es la investigaci�n y cu�l es su prop�sito?",
    "�Por qu� es importante llevar a cabo una investigaci�n?",
    "�Qu� pasos son necesarios para realizar una investigaci�n efectiva?",
    "�Qu� tipos de fuentes se pueden utilizar en una investigaci�n?"
};

        List<List<string>> optionsPool35 = new List<List<string>>()
{
    new List<string>() { "Proceso de b�squeda de conocimiento y comprensi�n", "No tiene prop�sito", "S�lo para obtener una calificaci�n", "M�todo para perder el tiempo" },
    new List<string>() { "Para ampliar el conocimiento y resolver problemas", "No es importante", "Para no hacer nada", "Para perder el tiempo" },
    new List<string>() { "Planificaci�n, recopilaci�n de datos, an�lisis y conclusiones", "No hay pasos necesarios", "Saltar directamente a las conclusiones", "Realizar la investigaci�n sin ning�n plan" },
    new List<string>() { "Libros, revistas, internet, entrevistas, experimentos, encuestas", "No hay fuentes disponibles", "S�lo internet", "S�lo libros" }
};

        List<int> correctAnswersPool35 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool36 = new List<string>()
{
    "�Por qu� es importante tener un empleo?",
    "�Qu� factores influyen en la b�squeda de empleo?",
    "�Cu�les son las habilidades necesarias para tener �xito en el trabajo?",
    "�Qu� aspectos se deben considerar al elegir una carrera?"
};

        List<List<string>> optionsPool36 = new List<List<string>>()
{
    new List<string>() { "Para obtener ingresos y desarrollarse profesionalmente", "No es importante", "Para depender de otros", "Para no hacer nada" },
    new List<string>() { "Educaci�n, experiencia, habilidades y oportunidades", "Nada influye en la b�squeda de empleo", "Suerte solamente", "No se necesita buscar empleo" },
    new List<string>() { "Comunicaci�n, trabajo en equipo, habilidades t�cnicas", "No se necesitan habilidades para tener �xito en el trabajo", "No hay habilidades importantes", "Para ser exitoso, no se necesitan habilidades" },
    new List<string>() { "Intereses, habilidades, oportunidades de crecimiento", "No hay aspectos a considerar", "Carrera de otra persona", "No se necesita elegir una carrera" }
};

        List<int> correctAnswersPool36 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question


        List<string> questionsPool37 = new List<string>()
{
    "�Cu�l es el papel de los trabajadores de la construcci�n?",
    "�Por qu� es importante el equipo de seguridad en el trabajo de construcci�n?",
    "�Qu� factores afectan el tiempo necesario para completar un proyecto de construcci�n?",
    "�Qu� habilidades son importantes para los trabajadores de la construcci�n?"
};

        List<List<string>> optionsPool37 = new List<List<string>>()
{
    new List<string>() { "Construir estructuras como casas y edificios", "No tienen ning�n papel", "S�lo observar", "Hacer da�o a las estructuras" },
    new List<string>() { "Para proteger a los trabajadores de lesiones", "No es importante el equipo de seguridad", "Para no usar equipo de seguridad", "Para hacer da�o a los trabajadores" },
    new List<string>() { "Tama�o del proyecto, condiciones clim�ticas, disponibilidad de recursos", "Nada afecta el tiempo", "El tiempo siempre es el mismo", "El clima no afecta el tiempo de construcci�n" },
    new List<string>() { "Habilidades t�cnicas, capacidad f�sica, atenci�n al detalle", "No se necesitan habilidades", "No hay habilidades importantes", "No es necesario tener habilidades" }
};

        List<int> correctAnswersPool37 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool38 = new List<string>()
{
    "�Por qu� es importante recibir un salario?",
    "�Qu� factores pueden influir en la variaci�n de los salarios?",
    "�Qu� habilidades son valoradas en el mercado laboral?",
    "�Por qu� es importante negociar el salario durante una entrevista de trabajo?"
};

        List<List<string>> optionsPool38 = new List<List<string>>()
{
    new List<string>() { "Para cubrir gastos y asegurar estabilidad financiera", "No es importante recibir un salario", "Para no hacer nada", "Para depender de otros" },
    new List<string>() { "Experiencia, educaci�n, demanda del mercado", "Nada influye en la variaci�n de los salarios", "La suerte solamente", "No hay factores que influyan en los salarios" },
    new List<string>() { "Habilidades t�cnicas, habilidades blandas, experiencia", "No se valoran habilidades en el mercado laboral", "No hay habilidades valoradas", "Las habilidades no importan en el mercado laboral" },
    new List<string>() { "Para obtener una compensaci�n justa por el trabajo realizado", "No es importante negociar el salario", "No se puede negociar el salario", "Para aceptar cualquier oferta sin cuestionarla" }
};

        List<int> correctAnswersPool38 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool39 = new List<string>()
{
    "�Qu� actividades se realizan en un edificio de oficinas?",
    "�Qu� instalaciones comunes suelen tener las oficinas?",
    "�Qu� habilidades son importantes para trabajar en una oficina?",
    "�Por qu� es importante la colaboraci�n entre los trabajadores de oficina?"
};

        List<List<string>> optionsPool39 = new List<List<string>>()
{
    new List<string>() { "Trabajo administrativo, reuniones, colaboraci�n en proyectos", "No se realizan actividades en un edificio de oficinas", "Solo reuniones", "Solo trabajo administrativo" },
    new List<string>() { "Cocina, sala de descanso, �rea de impresi�n", "No tienen instalaciones comunes", "Solo tienen cocina", "Solo tienen sala de descanso" },
    new List<string>() { "Buena comunicaci�n, habilidades organizativas, conocimientos inform�ticos", "No se necesitan habilidades para trabajar en una oficina", "No hay habilidades importantes", "Las habilidades no son importantes" },
    new List<string>() { "Para mejorar la eficiencia y lograr objetivos comunes", "No es importante la colaboraci�n", "No se necesita colaboraci�n", "Para hacer el trabajo m�s dif�cil" }
};

        List<int> correctAnswersPool39 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool40 = new List<string>()
{
    "�Qu� tipo de productos se venden en una tienda minorista?",
    "�Cu�les son algunas de las responsabilidades de los trabajadores minoristas?",
    "�Qu� habilidades son importantes para trabajar en el comercio minorista?",
    "�Por qu� es importante brindar un buen servicio al cliente en las tiendas minoristas?"
};

        List<List<string>> optionsPool40 = new List<List<string>>()
{
    new List<string>() { "Productos diversos como ropa, electr�nica, alimentos", "Solo se venden alimentos", "Solo se venden productos electr�nicos", "No se venden productos en las tiendas minoristas" },
    new List<string>() { "Atenci�n al cliente, reposici�n de mercanc�as, gesti�n de caja", "No tienen responsabilidades", "Solo tienen una responsabilidad", "Solo tienen dos responsabilidades" },
    new List<string>() { "Habilidades de comunicaci�n, atenci�n al cliente, manejo de efectivo", "No se necesitan habilidades para trabajar en el comercio minorista", "No hay habilidades importantes", "Las habilidades no son importantes" },
    new List<string>() { "Para mejorar la satisfacci�n del cliente y fomentar la fidelidad", "No es importante el servicio al cliente", "No se necesita brindar un buen servicio al cliente", "Para molestar a los clientes" }
};

        List<int> correctAnswersPool40 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool41 = new List<string>()
{
    "�Qu� tipo de servicios se ofrecen en un hospital?",
    "�Cu�les son algunas de las responsabilidades de los trabajadores de la salud en un hospital?",
    "�Qu� habilidades son importantes para trabajar en el campo de la salud?",
    "�Por qu� es importante proporcionar una atenci�n compasiva en un entorno hospitalario?"
};

        List<List<string>> optionsPool41 = new List<List<string>>()
{
    new List<string>() { "Atenci�n m�dica, emergencias, cirug�as", "Solo se ofrecen servicios de emergencia", "Solo se realizan cirug�as", "No se ofrecen servicios en los hospitales" },
    new List<string>() { "Brindar atenci�n m�dica, administrar medicamentos, realizar ex�menes", "No tienen responsabilidades", "Solo tienen una responsabilidad", "Solo tienen dos responsabilidades" },
    new List<string>() { "Conocimientos m�dicos, habilidades de comunicaci�n, capacidad para trabajar bajo presi�n", "No se necesitan habilidades para trabajar en el campo de la salud", "No hay habilidades importantes", "Las habilidades no son importantes" },
    new List<string>() { "Para generar confianza y comodidad en los pacientes durante momentos dif�ciles", "No es importante la atenci�n compasiva", "No se necesita proporcionar atenci�n compasiva", "Para hacer que los pacientes se sientan inc�modos" }
};

        List<int> correctAnswersPool41 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool42 = new List<string>()
{
    "�Qu� servicios se ofrecen en un banco?",
    "�Cu�les son algunas de las responsabilidades de los cajeros de banco?",
    "�Qu� habilidades son importantes para trabajar en un banco?",
    "�Por qu� es importante mantener medidas de seguridad estrictas en un banco?"
};

        List<List<string>> optionsPool42 = new List<List<string>>()
{
    new List<string>() { "Pr�stamos, cuentas de ahorro, servicios financieros", "Solo se ofrecen pr�stamos", "Solo se abren cuentas de ahorro", "No se ofrecen servicios en los bancos" },
    new List<string>() { "Manejar transacciones financieras, proporcionar servicios al cliente, verificar identidades", "No tienen responsabilidades", "Solo tienen una responsabilidad", "Solo tienen dos responsabilidades" },
    new List<string>() { "Habilidades matem�ticas, habilidades de comunicaci�n, atenci�n al detalle", "No se necesitan habilidades para trabajar en un banco", "No hay habilidades importantes", "Las habilidades no son importantes" },
    new List<string>() { "Para proteger los activos de los clientes y prevenir fraudes", "No es importante mantener medidas de seguridad estrictas", "No se necesitan medidas de seguridad estrictas", "Para exponer los activos de los clientes al peligro" }
};

        List<int> correctAnswersPool42 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool43 = new List<string>()
{
    "�Qu� tipo de lugar es una playa?",
    "�Qu� elementos naturales puedes encontrar en una playa?",
    "�Cu�les son algunas actividades comunes que se pueden hacer en la playa?",
    "�Por qu� las personas disfrutan de visitar la playa?"
};

        List<List<string>> optionsPool43 = new List<List<string>>()
{
    new List<string>() { "Una costa donde el mar se encuentra con la tierra", "Un �rea des�rtica", "Un �rea monta�osa", "Un lugar sin agua" },
    new List<string>() { "Arena, agua de mar, conchas marinas", "Hielo, nieve, rocas", "�rboles, pasto, hojas", "Edificios, carreteras, coches" },
    new List<string>() { "Nadar, tomar el sol, construir castillos de arena", "Esquiar, patinar, hacer snowboard", "Jugar al f�tbol, al baloncesto, al b�isbol", "Leer, estudiar, trabajar" },
    new List<string>() { "Porque ofrece oportunidades para relajarse, nadar y disfrutar del paisaje", "Porque es un lugar aburrido y sin nada que hacer", "Porque est� lleno de peligros y problemas", "Porque es un lugar lleno de contaminaci�n y basura" }
};

        List<int> correctAnswersPool43 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool44 = new List<string>()
{
    "�Qu� tipo de lugar es un parque?",
    "�Qu� caracter�sticas naturales y artificiales puedes encontrar en un parque?",
    "�Qu� actividades se pueden hacer en un parque?",
    "�Por qu� las personas disfrutan de visitar los parques?"
};

        List<List<string>> optionsPool44 = new List<List<string>>()
{
    new List<string>() { "Un �rea de terreno p�blico destinada al esparcimiento y la recreaci�n", "Una zona industrial", "Un lugar de trabajo", "Una �rea des�rtica" },
    new List<string>() { "�rboles, c�sped, bancos, fuentes", "Edificios altos, carreteras, autom�viles", "Monta�as, r�os, cuevas", "Playas, oc�anos, arrecifes de coral" },
    new List<string>() { "Caminar, correr, hacer picnic, jugar", "Bucear, hacer surf, pescar", "Conducir, viajar en avi�n, andar en bicicleta", "Trabajar, estudiar, cocinar" },
    new List<string>() { "Porque ofrecen �reas verdes y oportunidades para el ejercicio y la relajaci�n", "Porque son lugares peligrosos y aburridos", "Porque no hay nada interesante que hacer en los parques", "Porque los parques son lugares sucios y poco seguros" }
};

        List<int> correctAnswersPool44 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool45 = new List<string>()
{
    "�Qu� es un estadio?",
    "�Qu� eventos suelen tener lugar en un estadio?",
    "�Qu� instalaciones y caracter�sticas se pueden encontrar en un estadio?",
    "�Por qu� las personas disfrutan de asistir a eventos en los estadios?"
};

        List<List<string>> optionsPool45 = new List<List<string>>()
{
    new List<string>() { "Un lugar grande y al aire libre dise�ado para eventos deportivos y conciertos", "Un espacio cerrado para oficinas", "Una biblioteca", "Un restaurante lujoso" },
    new List<string>() { "Partidos de f�tbol, conciertos, competiciones deportivas", "Conferencias de negocios, reuniones familiares, clases de cocina", "Representaciones teatrales, ceremonias de premios, exhibiciones de arte", "Seminarios educativos, talleres de jardiner�a, sesiones de yoga" },
    new List<string>() { "Asientos para espectadores, campo de juego, pista de atletismo", "Piscinas, saunas, salas de masajes", "Laboratorios de ciencia, aulas de m�sica, estudios de arte", "Cocinas, ba�os, dormitorios" },
    new List<string>() { "Porque ofrecen emoci�n y entretenimiento, y son lugares para disfrutar de eventos en vivo", "Porque son lugares aburridos y sin nada que hacer", "Porque los eventos en los estadios son peligrosos y estresantes", "Porque los estadios son lugares sucios y poco seguros" }
};

        List<int> correctAnswersPool45 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool46 = new List<string>()
{
    "�Qu� es una fiesta?",
    "�Qu� ocasiones suelen celebrarse con fiestas?",
    "�Qu� actividades se pueden hacer en una fiesta?",
    "�Por qu� las personas disfrutan de asistir a fiestas?"
};

        List<List<string>> optionsPool46 = new List<List<string>>()
{
    new List<string>() { "Un evento social o reuni�n festiva para celebrar una ocasi�n especial", "Una cita m�dica", "Una reuni�n de negocios", "Un viaje al supermercado" },
    new List<string>() { "Cumplea�os, bodas, graduaciones, Navidad", "D�as laborales, d�as de escuela, d�as de descanso", "Ex�menes, entrevistas de trabajo, mudanzas", "D�as lluviosos, d�as soleados, d�as nublados" },
    new List<string>() { "Comer, beber, bailar, cantar", "Estudiar, trabajar, dormir", "Limpiar, organizar, cocinar", "Mirar televisi�n, leer libros, hacer ejercicio" },
    new List<string>() { "Porque son momentos de celebraci�n y diversi�n con amigos y familiares", "Porque las fiestas son aburridas y estresantes", "Porque las fiestas son lugares peligrosos y poco seguros", "Porque no hay nada interesante que hacer en las fiestas" }
};

        List<int> correctAnswersPool46 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool47 = new List<string>()
{
    "�Qu� es un restaurante?",
    "�Qu� tipos de restaurantes existen?",
    "�Qu� tipo de comida se puede encontrar en los restaurantes?",
    "�Por qu� las personas disfrutan de cenar en restaurantes?"
};

        List<List<string>> optionsPool47 = new List<List<string>>()
{
    new List<string>() { "Un establecimiento donde se sirven comidas preparadas para ser consumidas en el lugar", "Una biblioteca", "Una tienda de ropa", "Un gimnasio" },
    new List<string>() { "Restaurantes de comida r�pida, restaurantes de comida �tnica, restaurantes de lujo", "Hospitales, estaciones de polic�a, estaciones de bomberos", "Museos, cines, teatros", "Parques, playas, monta�as" },
    new List<string>() { "Comida italiana, comida china, comida mexicana, comida india, etc.", "Muebles, ropa, herramientas, electr�nicos", "Flores, plantas, hierbas, especias", "Libros, revistas, peri�dicos, c�mics" },
    new List<string>() { "Porque pueden disfrutar de una variedad de platos deliciosos sin tener que cocinar", "Porque los restaurantes son lugares aburridos y estresantes", "Porque los restaurantes son lugares sucios y poco higi�nicos", "Porque no hay nada interesante que hacer en los restaurantes" }
};

        List<int> correctAnswersPool47 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool48 = new List<string>()
{
    "�Qu� es Internet?",
    "�Para qu� se utiliza com�nmente Internet?",
    "�Qu� servicios y recursos est�n disponibles en Internet?",
    "�Por qu� las personas disfrutan de usar Internet?"
};

        List<List<string>> optionsPool48 = new List<List<string>>()
{
    new List<string>() { "Una red global de computadoras interconectadas que permite la comunicaci�n y el intercambio de informaci�n", "Un parque de diversiones", "Un zool�gico", "Un centro comercial" },
    new List<string>() { "Para acceder a informaci�n, comunicarse con otras personas, realizar compras en l�nea, entretenerse, etc.", "Para cocinar, limpiar, dormir, trabajar", "Para practicar deportes, hacer ejercicio, ir de compras", "Para estudiar, leer libros, ir al cine" },
    new List<string>() { "Correo electr�nico, redes sociales, sitios web de noticias, motores de b�squeda", "Ropa, muebles, electrodom�sticos, art�culos para el hogar", "Flores, plantas, hierbas, especias", "Comida, bebida, juguetes, juegos" },
    new List<string>() { "Porque proporciona acceso r�pido a una amplia gama de informaci�n y servicios", "Porque Internet es un lugar aburrido y estresante", "Porque Internet es peligroso y poco seguro", "Porque no hay nada interesante que hacer en Internet" }
};

        List<int> correctAnswersPool48 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question
        List<string> questionsPool49 = new List<string>()
{
    "�Qu� es una pel�cula?",
    "�Cu�l es el prop�sito principal de ver pel�culas?",
    "�Qu� g�neros de pel�culas son populares?",
    "�Por qu� las personas disfrutan de ver pel�culas?"
};

        List<List<string>> optionsPool49 = new List<List<string>>()
{
    new List<string>() { "Una forma de entretenimiento que consiste en una secuencia de im�genes en movimiento y sonido", "Un instrumento musical", "Una herramienta de jardiner�a", "Una comida r�pida" },
    new List<string>() { "Para entretenerse, emocionarse, aprender, reflexionar, etc.", "Para hacer ejercicio, cocinar, limpiar, trabajar", "Para practicar deportes, hacer compras, salir de fiesta", "Para estudiar, hacer diligencias, visitar museos" },
    new List<string>() { "Drama, comedia, acci�n, terror, ciencia ficci�n, romance, etc.", "Ropa, muebles, electrodom�sticos, art�culos para el hogar", "Flores, plantas, hierbas, especias", "Comida, bebida, juguetes, juegos" },
    new List<string>() { "Porque ofrecen una forma de escapar de la realidad y sumergirse en historias interesantes", "Porque las pel�culas son aburridas y predecibles", "Porque las pel�culas son largas y tediosas", "Porque no hay nada interesante que hacer mientras se ven pel�culas" }











};
        List<int> correctAnswersPool49 = new List<int>() { 0, 0, 0, 0 }; // Index of correct answers for each question














        // Add the pools to the main lists
        questionsPools.Add(questionsPool1);
        questionsPools.Add(questionsPool2);
        questionsPools.Add(questionsPool3);
        questionsPools.Add(questionsPool4);
        questionsPools.Add(questionsPool5);
        questionsPools.Add(questionsPool6);
        questionsPools.Add(questionsPool7);
        questionsPools.Add(questionsPool8);
        questionsPools.Add(questionsPool9);
        questionsPools.Add(questionsPool10);
        questionsPools.Add(questionsPool11);
        questionsPools.Add(questionsPool12);
        questionsPools.Add(questionsPool13);
        questionsPools.Add(questionsPool14);
        questionsPools.Add(questionsPool15);
        questionsPools.Add(questionsPool16);
        questionsPools.Add(questionsPool17);
        questionsPools.Add(questionsPool18);
        questionsPools.Add(questionsPool19);
        questionsPools.Add(questionsPool20);
        questionsPools.Add(questionsPool21);
        questionsPools.Add(questionsPool22);
        questionsPools.Add(questionsPool23);
        questionsPools.Add(questionsPool24);
        questionsPools.Add(questionsPool25);
        questionsPools.Add(questionsPool26);
        questionsPools.Add(questionsPool27);
        questionsPools.Add(questionsPool28);
        questionsPools.Add(questionsPool29);
        questionsPools.Add(questionsPool30);
        questionsPools.Add(questionsPool31);
        questionsPools.Add(questionsPool32);
        questionsPools.Add(questionsPool33);
        questionsPools.Add(questionsPool34);
        questionsPools.Add(questionsPool35);
        questionsPools.Add(questionsPool36);
        questionsPools.Add(questionsPool37);
        questionsPools.Add(questionsPool38);
        questionsPools.Add(questionsPool39);
        questionsPools.Add(questionsPool40);
        questionsPools.Add(questionsPool41);
        questionsPools.Add(questionsPool42);
        questionsPools.Add(questionsPool43);
        questionsPools.Add(questionsPool44);
        questionsPools.Add(questionsPool45);
        questionsPools.Add(questionsPool46);
        questionsPools.Add(questionsPool47);
        questionsPools.Add(questionsPool48);
        questionsPools.Add(questionsPool49);


        optionsPools.Add(optionsPool1);
        optionsPools.Add(optionsPool2);
        optionsPools.Add(optionsPool3);
        optionsPools.Add(optionsPool4);
        optionsPools.Add(optionsPool5);
        optionsPools.Add(optionsPool6);
        optionsPools.Add(optionsPool7);
        optionsPools.Add(optionsPool8);
        optionsPools.Add(optionsPool9);
        optionsPools.Add(optionsPool10);
        optionsPools.Add(optionsPool11);
        optionsPools.Add(optionsPool12);
        optionsPools.Add(optionsPool13);
        optionsPools.Add(optionsPool14);
        optionsPools.Add(optionsPool15);
        optionsPools.Add(optionsPool16);
        optionsPools.Add(optionsPool17);
        optionsPools.Add(optionsPool18);
        optionsPools.Add(optionsPool19);
        optionsPools.Add(optionsPool20);
        optionsPools.Add(optionsPool21);
        optionsPools.Add(optionsPool22);
        optionsPools.Add(optionsPool23);
        optionsPools.Add(optionsPool24);
        optionsPools.Add(optionsPool25);
        optionsPools.Add(optionsPool26);
        optionsPools.Add(optionsPool27);
        optionsPools.Add(optionsPool28);
        optionsPools.Add(optionsPool29);
        optionsPools.Add(optionsPool30);
        optionsPools.Add(optionsPool31);
        optionsPools.Add(optionsPool32);
        optionsPools.Add(optionsPool33);
        optionsPools.Add(optionsPool34);
        optionsPools.Add(optionsPool35);
        optionsPools.Add(optionsPool36);
        optionsPools.Add(optionsPool37);
        optionsPools.Add(optionsPool38);
        optionsPools.Add(optionsPool39);
        optionsPools.Add(optionsPool40);
        optionsPools.Add(optionsPool41);
        optionsPools.Add(optionsPool42);
        optionsPools.Add(optionsPool43);
        optionsPools.Add(optionsPool44);
        optionsPools.Add(optionsPool45);
        optionsPools.Add(optionsPool46);
        optionsPools.Add(optionsPool47);
        optionsPools.Add(optionsPool48);
        optionsPools.Add(optionsPool49);



        correctAnswersPools.Add(correctAnswersPool1);
        correctAnswersPools.Add(correctAnswersPool2);
        correctAnswersPools.Add(correctAnswersPool3);
        correctAnswersPools.Add(correctAnswersPool4);
        correctAnswersPools.Add(correctAnswersPool5);
        correctAnswersPools.Add(correctAnswersPool6);
        correctAnswersPools.Add(correctAnswersPool7);
        correctAnswersPools.Add(correctAnswersPool8);
        correctAnswersPools.Add(correctAnswersPool9);
        correctAnswersPools.Add(correctAnswersPool10);
        correctAnswersPools.Add(correctAnswersPool11);
        correctAnswersPools.Add(correctAnswersPool12);
        correctAnswersPools.Add(correctAnswersPool13);
        correctAnswersPools.Add(correctAnswersPool14);
        correctAnswersPools.Add(correctAnswersPool15);
        correctAnswersPools.Add(correctAnswersPool16);
        correctAnswersPools.Add(correctAnswersPool17);
        correctAnswersPools.Add(correctAnswersPool18);
        correctAnswersPools.Add(correctAnswersPool19);
        correctAnswersPools.Add(correctAnswersPool20);
        correctAnswersPools.Add(correctAnswersPool21);
        correctAnswersPools.Add(correctAnswersPool22);
        correctAnswersPools.Add(correctAnswersPool23);
        correctAnswersPools.Add(correctAnswersPool24);
        correctAnswersPools.Add(correctAnswersPool25);
        correctAnswersPools.Add(correctAnswersPool26);
        correctAnswersPools.Add(correctAnswersPool27);
        correctAnswersPools.Add(correctAnswersPool28);
        correctAnswersPools.Add(correctAnswersPool29);
        correctAnswersPools.Add(correctAnswersPool30);
        correctAnswersPools.Add(correctAnswersPool31);
        correctAnswersPools.Add(correctAnswersPool32);
        correctAnswersPools.Add(correctAnswersPool33);
        correctAnswersPools.Add(correctAnswersPool34);
        correctAnswersPools.Add(correctAnswersPool35);
        correctAnswersPools.Add(correctAnswersPool36);
        correctAnswersPools.Add(correctAnswersPool37);
        correctAnswersPools.Add(correctAnswersPool38);
        correctAnswersPools.Add(correctAnswersPool39);
        correctAnswersPools.Add(correctAnswersPool40);
        correctAnswersPools.Add(correctAnswersPool41);
        correctAnswersPools.Add(correctAnswersPool42);
        correctAnswersPools.Add(correctAnswersPool43);
        correctAnswersPools.Add(correctAnswersPool44);
        correctAnswersPools.Add(correctAnswersPool45);
        correctAnswersPools.Add(correctAnswersPool46);
        correctAnswersPools.Add(correctAnswersPool47);
        correctAnswersPools.Add(correctAnswersPool48);
        correctAnswersPools.Add(correctAnswersPool49);

    }










    public void OpenQuizPanel(int poolIndex, int questionIndex)
    {
        // Assuming poolIndex is the index of the pool you want to use
     //   ShuffleQuestionsAndOptions(poolIndex);
        DisplayQuestion(poolIndex, questionIndex); // Display the first question from the specified pool
    }




    void ShuffleQuestionsAndOptions(int poolIndex)
    {
        // Shuffle questions, options, and correct answers using Fisher-Yates shuffle algorithm
        System.Random rng = new System.Random();
        List<string> questions = questionsPools[poolIndex];
        List<List<string>> options = optionsPools[poolIndex];
        List<int> correctAnswers = correctAnswersPools[poolIndex];

        int n = questions.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            string tempQuestion = questions[k];
            List<string> tempOptions = options[k];
            int tempCorrectAnswer = correctAnswers[k];
            questions[k] = questions[n];
            options[k] = options[n];
            correctAnswers[k] = correctAnswers[n];
            questions[n] = tempQuestion;
            options[n] = tempOptions;
            correctAnswers[n] = tempCorrectAnswer;

            // Shuffle options for the current question
            for (int i = 0; i < tempOptions.Count; i++)
            {
                int randIndex = rng.Next(i, tempOptions.Count);
                string tempOption = tempOptions[i];
                tempOptions[i] = tempOptions[randIndex];
                tempOptions[randIndex] = tempOption;
            }
        }
    }




    void DisplayQuestion(int poolIndex, int index)
    {
        List<string> questions = questionsPools[poolIndex];
        List<List<string>> options = optionsPools[poolIndex];
        _questionText.text = questions[index];

        for (int i = 0; i < optionButtons.Length; i++)
        {
            optionButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = options[index][i];
        }
    }




















    void InitializeQuiz()
    {
        // Define all your quiz questions, options, and correct answers here
        questions = new List<string>()
        {
            "What is the capital of France?",
            "Which planet is known as the Red Planet?",
            // Add more questions here...
        };

        options = new List<List<string>>()
        {
            new List<string>() { "Paris", "London", "Berlin", "Rome" },
            new List<string>() { "Mars", "Venus", "Jupiter", "Saturn" },
            // Add more options for each question...
        };

        correctAnswers = new List<int>() { 0, 0 }; // Index of correct answers for each question
    }

    // public void OpenQuizPanel()
    //  {

    //    ShuffleQuestionsAndOptions();
    //   DisplayQuestion(0); // Display the first question
    // }
    /*
    void ShuffleQuestionsAndOptions()
    {
        // Shuffle questions, options, and correct answers using Fisher-Yates shuffle algorithm
        System.Random rng = new System.Random();
        int n = questions.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            string tempQuestion = questions[k];
            List<string> tempOptions = options[k];
            int tempCorrectAnswer = correctAnswers[k];
            questions[k] = questions[n];
            options[k] = options[n];
            correctAnswers[k] = correctAnswers[n];
            questions[n] = tempQuestion;
            options[n] = tempOptions;
            correctAnswers[n] = tempCorrectAnswer;
        }
    }
   
    void DisplayQuestion(int index)
    {
        _questionText.text = questions[index];

        for (int i = 0; i < optionButtons.Length; i++)
        {
            optionButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = options[index][i];
        }
    }
    */
    public void SelectOption(int optionIndex)
    {

        PlayerData playerData = saveManager.GetPlayerData();

        if (playerData.scrapAmount >= ((playerData.starLevel+1) * 10))
        {

       


                 if (optionIndex == correctAnswers[0]) // Check the answer for the first question only
                     {
               Debug.Log("Correct!");
            // Handle correct answer logic here
            correctorIncorrectText.text = "Correct! \n(wait for reset)";
            detectImageQuiz.AButtonToggle.SetActive(false);
            detectImageQuiz.BButtonToggle.SetActive(false);
            detectImageQuiz.CButtonToggle.SetActive(false);
            detectImageQuiz.DButtonToggle.SetActive(false);

            
            playerData.starLevel++;
            playerData.scrapAmount = playerData.scrapAmount - ((playerData.starLevel+1) * 10);
            detectImageQuiz.brainpowerAndCostText.text = "Brainpower: " + playerData.scrapAmount + " \nCost: " + (playerData.starLevel + 1) * 10;
                detectImageQuiz.starlevelText.text = "Star: \n" + playerData.starLevel.ToString();
                saveManager.SavePlayerData();

                for (int i = 0; i < detectImageQuiz.interestedTags.Length; i++)
                {
                    // Check if the current tag matches the one to detect
                    if (detectImageQuiz.tagToDetect == detectImageQuiz.interestedTags[i])
                    {
                        // Set the corresponding cooldown value
                        star_cooldownValues[i] = "NotReady";
                        // Exit the loop since the match is found
                        break;
                    }
                }




                UpdateStarVisibility();
                 }
                 else
                     {
            Debug.Log("Incorrect!");
            correctorIncorrectText.text = "Incorrect! \n(wait for reset)";
            detectImageQuiz.AButtonToggle.SetActive(false);
            detectImageQuiz.BButtonToggle.SetActive(false);
            detectImageQuiz.CButtonToggle.SetActive(false);
            detectImageQuiz.DButtonToggle.SetActive(false);

                star_cooldownValues[0] = "NotReady";
         

                playerData.scrapAmount = playerData.scrapAmount - ((playerData.starLevel+1) * 10);
                detectImageQuiz.brainpowerAndCostText.text = "Brainpower: " + playerData.scrapAmount + " \nCost: " + (playerData.starLevel + 1) * 10;
                saveManager.SavePlayerData();

                // Handle incorrect answer logic here
                for (int i = 0; i < detectImageQuiz.interestedTags.Length; i++)
                {
                    // Check if the current tag matches the one to detect
                    if (detectImageQuiz.tagToDetect == detectImageQuiz.interestedTags[i])
                    {
                        // Set the corresponding cooldown value
                        star_cooldownValues[i] = "NotReady";
                        // Exit the loop since the match is found
                        break;
                    }
                }


            }



        }

        else { gameManager.ToggleVisibility(); }
   
    //  quizPanel.SetActive(false); // Automatically close the quiz panel after answering
}






    public GameObject[] starlevelGameObjects;

    void UpdateStarVisibility()
    {
        // Loop through each game object

        PlayerData playerData = saveManager.GetPlayerData();

        for (int i = 0; i < starlevelGameObjects.Length; i++)
        {
            // Check if the current game object should be activated based on star level
            if (i < 5 && playerData.starLevel >= i + 1) // Activate first 5 game objects every 1 star level
            {
                starlevelGameObjects[i].SetActive(true);
            }
            else if (i >= 5 && (playerData.starLevel - 5) / 5 >= i - 4) // Activate game objects after the 5th one every 5 star levels
            {
                starlevelGameObjects[i].SetActive(true);
            }
            else
            {
                // Deactivate the game object if the condition is not met
                starlevelGameObjects[i].SetActive(false);
            }
        }
    }
}