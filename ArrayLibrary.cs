using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayLibrary : MonoBehaviour
{
    // Start is called before the first frame update



    public string[] WORLD_textsArray = {
          "In Toronto, there are more Spanish-speaking people now. Recent estimates say there are about 100,000 Spanish speakers in Toronto. \n <color=red>En Toronto, ahora hay más personas que hablan español. Según estimaciones recientes, hay alrededor de 100,000 personas que hablan español en Toronto.</color>",
    "New Mexico's mix of Spanish and Native American influences creates unique traditions. \n<color=red>La mezcla de influencias españolas y amerindias de Nuevo México crea tradiciones únicas.",
    "In San Juan, Puerto Rico, Old San Juan is known for its colorful colonial buildings, cobblestone streets, and historic forts. \n<color=red>En San Juan, Puerto Rico, el Viejo San Juan es conocido por sus coloridos edificios coloniales, calles empedradas y fortalezas históricas.",
    "In Oaxaca, Mexico, the Day of the Dead celebration is a colorful tradition where families honor their loved ones. \n<color=red>En Oaxaca, México, el Día de los Muertos es una tradición colorida donde las familias honran a sus seres queridos.",
    "Texas's Spanish heritage is evident in its architecture and Tex-Mex cuisine. \n<color=red>La herencia española de Texas se refleja en su arquitectura y en la cocina Tex-Mex.",
    "Cities like Santa Fe and St. Augustine preserve Spanish colonial architecture. \n<color=red>Ciudades como Santa Fe y San Agustín conservan la arquitectura colonial española.",
"In Turkey, Spanish literature is studied by students interested in Hispanic culture, with universities offering courses. \n<color=red>En Turquía, la literatura española es estudiada por estudiantes interesados en la cultura hispana, con universidades que ofrecen cursos.",
"In Morocco, Spanish influence is seen in the architecture of cities like Tangier. \n<color=red>En Marruecos, la influencia española se ve en la arquitectura de ciudades como Tánger.",
    "In Barcelona, Spain, Antoni Gaudí's masterpiece, the Sagrada Familia, is a UNESCO World Heritage Site and an iconic symbol of the city. \n<color=red>En Barcelona, España, la obra maestra de Antoni Gaudí, la Sagrada Familia, es un sitio del Patrimonio Mundial de la UNESCO y un símbolo icónico de la ciudad.",
    "In Japan, Spanish cuisine has gained popularity, with sushi restaurants incorporating Spanish flavors. \n<color=red>En Japón, la cocina española ha ganado popularidad, con restaurantes de sushi que incorporan sabores españoles.",
    "In Granada, Spain, the Alhambra is a stunning palace known for its intricate architecture and beautiful gardens. \n<color=red>En Granada, España, la Alhambra es un impresionante palacio conocido por su arquitectura intrincada y hermosos jardines.",
    "In Valencia, Spain, the City of Arts and Sciences is a futuristic complex with stunning architecture and an aquarium. \n<color=red>En Valencia, España, la Ciudad de las Artes y las Ciencias es un complejo futurista con arquitectura impresionante y un acuario.",
    "In Slovakia, people watch Spanish plays in theaters. \n<color=red>En Eslovaquia, la gente ve obras españolas en teatros.",
 "In South Korea, Spanish language and culture are embraced, leading to Spanish schools and festivals. \n<color=red>En Corea del Sur, el idioma y la cultura españoles son abrazados, lo que lleva a escuelas y festivales.",
    "In Ukraine, students learn Spanish in programs. \n<color=red>En Ucrania, los estudiantes aprenden español en programas.",
   "In Cartagena, Colombia, the historic walled city is a UNESCO World Heritage Site with colorful colonial architecture. \n<color=red>En Cartagena, Colombia, la ciudad amurallada es Patrimonio Mundial de la UNESCO con arquitectura colonial colorida.",
    "In Havana, Cuba, the Malecón is a seaside promenade where locals and visitors enjoy stunning ocean views. \n<color=red>En La Habana, Cuba, el Malecón es un paseo marítimo donde locales y visitantes disfrutan de impresionantes vistas al océano.",
    "California's Spanish heritage is seen in its architecture and cuisine. \n<color=red>La herencia española de California se ve en su arquitectura y cocina.",
    "In Hungary, people taste Spanish wines at events. \n<color=red>En Hungría, la gente prueba vinos españoles en eventos.",
    "In Madrid, Spain, the Prado Museum houses an extensive collection of European art, including works by Velázquez, Goya, and El Greco. \n<color=red>En Madrid, España, el Museo del Prado alberga una extensa colección de arte europeo, incluyendo obras de Velázquez, Goya y El Greco.",
    "In Lima, Peru, ceviche is a popular dish made from fresh raw fish marinated in citrus juices. \n<color=red>En Lima, Perú, el ceviche es un plato popular hecho de pescado crudo fresco marinado en jugos cítricos.",
"In Jordan, Spanish heritage sites like the Umayyad Palace Complex offer views of Spain's rich history, attracting tourists. \n<color=red>En Jordania, sitios del patrimonio español como el Complejo del Palacio Omeya ofrecen vistas de la rica historia de España, atrayendo turistas.",
    "In the Philippines, Spanish influence is seen in the architecture of Intramuros, the historic walled city of Manila. \n<color=red>En Filipinas, la influencia española se ve en la arquitectura de Intramuros, la ciudad amurallada histórica de Manila.",
    "In Santiago, Chile, Cerro San Cristóbal offers panoramic views of the city and the Andes Mountains. \n<color=red>En Santiago, Chile, el Cerro San Cristóbal ofrece vistas panorámicas de la ciudad y la Cordillera de los Andes.",
          "In Seville, Spain, the annual Feria de Abril (April Fair) features traditional flamenco dancing and colorful costumes. \n<color=red>En Sevilla, España, la Feria de Abril presenta bailes tradicionales de flamenco y trajes coloridos.",
    "Miami's Hispanic community adds vibrancy with festivals, art, and cuisine. \n<color=red>La comunidad hispana de Miami agrega vitalidad con festivales, arte y cocina.",
    "In Buenos Aires, tango is a cultural phenomenon, with live performances in milongas (tango clubs) throughout the city. \n<color=red>En Buenos Aires, el tango es un fenómeno cultural, con actuaciones en vivo en milongas (clubes de tango) en toda la ciudad.",
    "In Mexico City, the Frida Kahlo Museum showcases the life and work of the iconic artist Frida Kahlo. \n<color=red>En la Ciudad de México, el Museo Frida Kahlo exhibe la vida y obra de la icónica artista Frida Kahlo.",
"In China, Spanish language learning is popular among students and professionals. \n<color=red>En China, el aprendizaje del español es popular entre estudiantes y profesionales.",
    "Hispanic Heritage Month celebrates Hispanic Americans' contributions to US culture. \n<color=red>El Mes de la Herencia Hispana celebra las contribuciones de los hispanoamericanos a la cultura estadounidense.",
    "In Cusco, Peru, Machu Picchu is one of the New Seven Wonders of the World, attracting millions of visitors. \n<color=red>En Cusco, Perú, Machu Picchu es una de las Nuevas Siete Maravillas del Mundo, atrayendo a millones de visitantes.",
"In the United Arab Emirates, Spanish cuisine is popular, with restaurants offering tapas and paella. \n<color=red>En los Emiratos Árabes Unidos, la cocina española es popular, con restaurantes que ofrecen tapas y paella.",
    "In Guam, Spanish colonial rule left a lasting impact on the island's culture, language, and traditions. \n<color=red>En Guam, el dominio colonial español dejó un impacto duradero en la cultura, el idioma y las tradiciones de la isla.",
    "In Bulgaria, people eat Spanish tapas in bars. \n<color=red>En Bulgaria, la gente come tapas españolas en bares.",
"In the former Spanish colony of Taiwan, remnants of Spanish influence can be found in place names and records. \n<color=red>En la antigua colonia española de Taiwán, se encuentran vestigios de influencia española en nombres y registros",
"In Poland, Spanish film festivals feature screenings of contemporary and classic Spanish films. \n<color=red>En Polonia, los festivales de cine español presentan proyecciones de películas contemporáneas y clásicas.",
      "In Romania, people learn Spanish flamenco from Spanish teachers. \n<color=red>En Rumania, la gente aprende flamenco español de maestros españoles.",
    "Spanish-language TV networks like Univision and Telemundo cater to US Hispanic population. \n<color=red>Las cadenas de televisión en español como Univisión y Telemundo atienden a la población hispana de EE. UU.",
    "In Buenos Aires, Argentina, the Teatro Colón is one of the world's most famous opera houses, renowned for its acoustics and grandeur. \n<color=red>En Buenos Aires, Argentina, el Teatro Colón es una de las óperas más famosas del mundo, conocida por su acústica y grandeza.",
    "In Macau, Portuguese-Spanish influence is reflected in historic buildings like the Ruins of St. Paul's. \n<color=red>En Macao, la influencia portuguesa-española se refleja en edificios históricos como las Ruinas de San Pablo.",
"In Qatar, Spanish art and culture are showcased through exhibitions and events. \n<color=red>En Qatar, el arte y la cultura españoles se exhiben a través de exposiciones y eventos.",
"In Lebanon, Spanish language learning is increasingly popular, with many institutions offering courses. \n<color=red>En Líbano, el aprendizaje del español es cada vez más popular, con muchas instituciones que ofrecen cursos.",
  "In Israel, Spanish music and dance are featured in cultural festivals, attracting diverse audiences. \n<color=red>En Israel, la música y el baile españoles son destacados en festivales culturales, atrayendo a audiencias diversas.",


};








    public string[] WORLD_textsArray_Mexico = {
    "In Mexico City, the Day of the Dead celebration is a colorful tradition where families honor their loved ones. \n<color=red>En la Ciudad de México, el Día de los Muertos es una tradición colorida donde las familias honran a sus seres queridos.</color>",
    "In Guadalajara, Mexico, the Mariachi music tradition is deeply rooted, with Mariachi bands performing in plazas and restaurants. \n<color=red>En Guadalajara, México, la tradición musical del Mariachi está profundamente arraigada, con bandas de Mariachi actuando en plazas y restaurantes.</color>",
    "In Cancun, Mexico, the pristine beaches and turquoise waters attract tourists from around the world. \n<color=red>En Cancún, México, las playas vírgenes y las aguas turquesas atraen a turistas de todo el mundo.</color>",
    "In Oaxaca, Mexico, the cuisine is celebrated for its rich flavors and use of indigenous ingredients like chocolate and mole sauce. \n<color=red>En Oaxaca, México, la cocina es celebrada por sus sabores ricos y el uso de ingredientes indígenas como el chocolate y la salsa mole.</color>",
    "In Mérida, Mexico, the Mayan culture is still present in its architecture, cuisine, and traditions. \n<color=red>En Mérida, México, la cultura maya sigue presente en su arquitectura, cocina y tradiciones.</color>",
    "In Monterrey, Mexico, the industrial hub of the country, you'll find a blend of modern skyscrapers and historic landmarks. \n<color=red>En Monterrey, México, el centro industrial del país, encontrarás una mezcla de rascacielos modernos y lugares históricos.</color>",
    "In Puebla, Mexico, the colonial architecture and vibrant culture attract visitors from all over the world. \n<color=red>En Puebla, México, la arquitectura colonial y la cultura vibrante atraen a visitantes de todo el mundo.</color>",
    "In Tulum, Mexico, the ancient Mayan ruins overlook the Caribbean Sea, creating a stunning backdrop for visitors. \n<color=red>En Tulum, México, las antiguas ruinas mayas tienen vista al Mar Caribe, creando un telón de fondo impresionante para los visitantes.</color>",
    "In Chiapas, Mexico, the lush landscapes and indigenous communities offer a glimpse into Mexico's rich cultural heritage. \n<color=red>En Chiapas, México, los paisajes exuberantes y las comunidades indígenas ofrecen una visión de la rica herencia cultural de México.</color>",
    "In Guanajuato, Mexico, the colorful buildings and winding streets make it a charming destination for travelers. \n<color=red>En Guanajuato, México, los edificios coloridos y las calles sinuosas lo convierten en un destino encantador para los viajeros.</color>",
    "In Veracruz, Mexico, the lively music, delicious cuisine, and coastal beauty attract visitors year-round. \n<color=red>En Veracruz, México, la música animada, la deliciosa cocina y la belleza costera atraen a visitantes durante todo el año.</color>",
    "In Tijuana, Mexico, the bustling border city offers a unique blend of Mexican and American cultures. \n<color=red>En Tijuana, México, la bulliciosa ciudad fronteriza ofrece una mezcla única de culturas mexicanas y estadounidenses.</color>",
    "In Acapulco, Mexico, the iconic cliff divers of La Quebrada perform daring feats for spectators. \n<color=red>En Acapulco, México, los icónicos clavadistas de La Quebrada realizan hazañas audaces para los espectadores.</color>",
    "In Chiapas, Mexico, the Zapatista movement has played a significant role in indigenous rights and social justice. \n<color=red>En Chiapas, México, el movimiento zapatista ha desempeñado un papel significativo en los derechos indígenas y la justicia social.</color>",
    "In Puerto Vallarta, Mexico, the charming old town and beautiful beaches make it a popular tourist destination. \n<color=red>En Puerto Vallarta, México, el encantador casco antiguo y las hermosas playas lo convierten en un destino turístico popular.</color>"
};

    public string[] WORLD_textsArray_Spanish = {
    "In Paris, France, the Eiffel Tower is an iconic symbol of the city, attracting millions of visitors each year. \n<color=red>En París, Francia, la Torre Eiffel es un símbolo icónico de la ciudad que atrae a millones de visitantes cada año.</color>",
    "In Lyon, France, the Festival of Lights is a dazzling celebration where the city comes alive with stunning light displays. \n<color=red>En Lyon, Francia, la Fiesta de las Luces es una celebración deslumbrante donde la ciudad cobra vida con impresionantes exhibiciones de luces.</color>",
    "In Nice, France, the Promenade des Anglais is a picturesque waterfront promenade lined with palm trees and cafes. \n<color=red>En Niza, Francia, la Promenade des Anglais es un paseo marítimo pintoresco bordeado de palmeras y cafés.</color>",
    "In Marseille, France, the Old Port is a vibrant hub of activity with bustling markets and seafood restaurants. \n<color=red>En Marsella, Francia, el Puerto Viejo es un animado centro de actividad con bulliciosos mercados y restaurantes de mariscos.</color>",
    "In Bordeaux, France, the wine capital, visitors can explore historic vineyards and sample world-renowned wines. \n<color=red>En Burdeos, Francia, la capital del vino, los visitantes pueden explorar viñedos históricos y degustar vinos de renombre mundial.</color>",
    "In Strasbourg, France, the beautiful half-timbered houses of La Petite France charm visitors with their medieval charm. \n<color=red>En Estrasburgo, Francia, las hermosas casas de entramado de madera de La Petite France encantan a los visitantes con su encanto medieval.</color>",
    "In Cannes, France, the annual film festival attracts celebrities and filmmakers from around the world. \n<color=red>En Cannes, Francia, el festival de cine anual atrae a celebridades y cineastas de todo el mundo.</color>",
    "In Toulouse, France, the pink city, visitors can explore medieval streets and marvel at the stunning architecture. \n<color=red>En Toulouse, Francia, la ciudad rosa, los visitantes pueden explorar calles medievales y maravillarse ante la impresionante arquitectura.</color>",
    "In Montpellier, France, the historic city center is filled with charming squares, fountains, and lively cafes. \n<color=red>En Montpellier, Francia, el centro histórico de la ciudad está lleno de encantadoras plazas, fuentes y cafés animados.</color>",
    "In Avignon, France, the Palais des Papes is a magnificent medieval palace and a UNESCO World Heritage Site. \n<color=red>En Aviñón, Francia, el Palais des Papes es un magnífico palacio medieval y un sitio del Patrimonio Mundial de la UNESCO.</color>",
    "In Biarritz, France, the stunning beaches and world-class surf make it a popular destination for beachgoers. \n<color=red>En Biarritz, Francia, las impresionantes playas y el surf de clase mundial lo convierten en un destino popular para los amantes de la playa.</color>",
    "In Lille, France, the Grand Place is a beautiful square surrounded by historic buildings and bustling cafes. \n<color=red>En Lille, Francia, la Grand Place es una hermosa plaza rodeada de edificios históricos y cafés animados.</color>",
    "In Normandy, France, the D-Day landing beaches and historic sites offer a poignant reminder of World War II. \n<color=red>En Normandía, Francia, las playas del desembarco del Día D y los sitios históricos ofrecen un recordatorio conmovedor de la Segunda Guerra Mundial.</color>",
    "In Provence, France, the picturesque countryside is dotted with lavender fields, vineyards, and charming villages. \n<color=red>En Provenza, Francia, la pintoresca campiña está salpicada de campos de lavanda, viñedos y encantadores pueblos.</color>",
    "In Alsace, France, the quaint villages and rolling vineyards offer visitors a taste of traditional French charm. \n<color=red>En Alsacia, Francia, los pintorescos pueblos y los viñedos ondulados ofrecen a los visitantes un sabor del encanto tradicional francés.</color>",
    "In Brittany, France, the rugged coastline is dotted with historic lighthouses and picturesque fishing villages. \n<color=red>En Bretaña, Francia, la costa escarpada está salpicada de faros históricos y pintorescos pueblos de pescadores.</color>"
};



    public string[] WORLD_textsArray_Vietnam_Spanish = {
    "In Hanoi, Vietnam, el Barrio Antiguo es conocido por sus calles estrechas, templos antiguos y bulliciosos mercados. \n<color=red>En Hanoi, Vietnam, el Barrio Antiguo es conocido por sus calles estrechas, templos antiguos y bulliciosos mercados.</color>",
    "En la ciudad de Ho Chi Minh, Vietnam, el Mercado Ben Thanh es un destino popular para ir de compras y probar la comida callejera local. \n<color=red>En la ciudad de Ho Chi Minh, Vietnam, el Mercado Ben Thanh es un destino popular para ir de compras y probar la comida callejera local.</color>",
    "En Hoi An, Vietnam, la Ciudad Antigua es un sitio del Patrimonio Mundial de la UNESCO conocido por sus edificios históricos bien conservados y calles iluminadas por faroles. \n<color=red>En Hoi An, Vietnam, la Ciudad Antigua es un sitio del Patrimonio Mundial de la UNESCO conocido por sus edificios históricos bien conservados y calles iluminadas por faroles.</color>",
    "En Da Nang, Vietnam, el Puente del Dragón es una maravilla moderna con su diseño en forma de dragón y luces LED de colores. \n<color=red>En Da Nang, Vietnam, el Puente del Dragón es una maravilla moderna con su diseño en forma de dragón y luces LED de colores.</color>",
    "En Nha Trang, Vietnam, las playas prístinas y las aguas cristalinas la convierten en un destino popular para los amantes de la playa. \n<color=red>En Nha Trang, Vietnam, las playas prístinas y las aguas cristalinas la convierten en un destino popular para los amantes de la playa.</color>",
    "En Hue, Vietnam, la Ciudad Imperial es un complejo histórico con antiguas citadelas, templos y palacios. \n<color=red>En Hue, Vietnam, la Ciudad Imperial es un complejo histórico con antiguas citadelas, templos y palacios.</color>",
    "En Phong Nha, Vietnam, el Parque Nacional Phong Nha-Ke Bang alberga impresionantes cuevas de piedra caliza y exuberantes selvas. \n<color=red>En Phong Nha, Vietnam, el Parque Nacional Phong Nha-Ke Bang alberga impresionantes cuevas de piedra caliza y exuberantes selvas.</color>",
    "En Sapa, Vietnam, los campos de arroz escalonados y los pueblos de minorías étnicas ofrecen vistas impresionantes y experiencias culturales. \n<color=red>En Sapa, Vietnam, los campos de arroz escalonados y los pueblos de minorías étnicas ofrecen vistas impresionantes y experiencias culturales.</color>",
    "En la Bahía de Ha Long, Vietnam, las islas de piedra caliza y las aguas esmeralda crean un impresionante paisaje natural. \n<color=red>En la Bahía de Ha Long, Vietnam, las islas de piedra caliza y las aguas esmeralda crean un impresionante paisaje natural.</color>",
    "En el Delta del Mekong, Vietnam, la exuberante vegetación y la intrincada red de vías fluviales ofrecen una visión de la vida rural. \n<color=red>En el Delta del Mekong, Vietnam, la exuberante vegetación y la intrincada red de vías fluviales ofrecen una visión de la vida rural.</color>",
    "En Dalat, Vietnam, el clima fresco, los jardines de flores y la arquitectura colonial francesa la convierten en una estación de montaña popular. \n<color=red>En Dalat, Vietnam, el clima fresco, los jardines de flores y la arquitectura colonial francesa la convierten en una estación de montaña popular.</color>",
    "En Quy Nhon, Vietnam, las playas prístinas y los antiguos templos Cham ofrecen una escapada serena. \n<color=red>En Quy Nhon, Vietnam, las playas prístinas y los antiguos templos Cham ofrecen una escapada serena.</color>",
    "En Con Dao, Vietnam, las islas tranquilas y los restos históricos de la prisión ofrecen un recordatorio conmovedor del pasado de Vietnam. \n<color=red>En Con Dao, Vietnam, las islas tranquilas y los restos históricos de la prisión ofrecen un recordatorio conmovedor del pasado de Vietnam.</color>",
    "En Phu Quoc, Vietnam, las playas bordeadas de palmeras y los vibrantes arrecifes de coral la convierten en un destino ideal para hacer snorkel y relajarse. \n<color=red>En Phu Quoc, Vietnam, las playas bordeadas de palmeras y los vibrantes arrecifes de coral la convierten en un destino ideal para hacer snorkel y relajarse.</color>"
};















    // public string[] Basic3_textsArray = { "3333333", "33", "asdfas333dfmouse", "Th333is asdfasdis a <color=red>colored</color> word." };

    public string[] array1;

    public string[] Basic1_textsArray = {
    "house. \n<color=red> casa.",
    "dog. \n<color=red> perro.",
    "kitchen. \n<color=red> cocina.",
    "bedroom. \n<color=red> habitación.",
    "living room. \n<color=red> salón."
};

    public string[] Basic2_textsArray = {
    "chair. \n<color=red> silla.",
    "table. \n<color=red> mesa.",
    "bed. \n<color=red> cama.",
    "lamp. \n<color=red> lámpara.",
    "sofa. \n<color=red> sofá."
};

    public string[] Basic3_textsArray = {
    "backyard. \n<color=red> patio trasero.",
    "flowers. \n<color=red> flores.",
    "swing. \n<color=red> columpio.",
    "vegetables. \n<color=red> verduras.",
    "dog. \n<color=red> perro."
};

    public string[] Basic4_textsArray = {
    "mom. \n<color=red> mamá.",
    "dad. \n<color=red> papá.",
    "sister. \n<color=red> hermana.",
    "brother. \n<color=red> hermano.",
    "grandparents. \n<color=red> abuelos."
};

    public string[] Basic5_textsArray = {
    "light. \n<color=red> luz.",
    "water. \n<color=red> agua.",
    "heater. \n<color=red> calefacción.",
    "air conditioner. \n<color=red> aire acondicionado.",
    "internet. \n<color=red> internet."
};

    public string[] Basic6_textsArray = {
    "picture. \n<color=red> cuadro.",
    "flowers. \n<color=red> flores.",
    "curtains. \n<color=red> cortinas.",
    "rug. \n<color=red> alfombra.",
    "pillows. \n<color=red> cojines."
};

    public string[] Basic7_textsArray = {
    "door. \n<color=red> puerta.",
    "window. \n<color=red> ventana.",
    "wall. \n<color=red> pared.",
    "floor. \n<color=red> suelo.",
    "roof. \n<color=red> techo."
};


    public string[] Basic8_textsArray = {
    "adventure. \n<color=red> aventura.",
    "walk. \n<color=red> paseo.",
    "zoo. \n<color=red> zoológico.",
    "mountain. \n<color=red> montaña.",
    "picnic. \n<color=red> picnic."
};

    public string[] Basic9_textsArray = {
    "traditions. \n<color=red> tradiciones.",
    "movies. \n<color=red> películas.",
    "music. \n<color=red> música.",
    "books. \n<color=red> libros.",
    "festival. \n<color=red> festival."
};

    public string[] Basic10_textsArray = {
    "walk. \n<color=red> paseo.",
    "picnic. \n<color=red> picnic.",
    "play. \n<color=red> juego.",
    "exploring. \n<color=red> exploración.",
    "camping. \n<color=red> camping."
};

    public string[] Basic11_textsArray = {
    "museum. \n<color=red> museo.",
    "buildings. \n<color=red> edificios.",
    "stories. \n<color=red> historias.",
    "documentaries. \n<color=red> documentales.",
    "book. \n<color=red> libro."
};

    public string[] Basic12_textsArray = {
    "break. \n<color=red> descanso.",
    "music. \n<color=red> música.",
    "bath. \n<color=red> baño.",
    "hammock. \n<color=red> hamaca.",
    "night. \n<color=red> noche."
};

    public string[] Basic13_textsArray = {
    "meal. \n<color=red> comida.",
    "pizza. \n<color=red> pizza.",
    "cookies. \n<color=red> galletas.",
    "cuisine. \n<color=red> cocina.",
    "class. \n<color=red> clase."
};

    public string[] Basic14_textsArray = {
    "neighborhood. \n<color=red> vecindario.",
    "recommendations. \n<color=red> recomendaciones.",
    "cafes. \n<color=red> cafés.",
    "exploration. \n<color=red> exploración.",
    "hike. \n<color=red> caminata."
};













    public string[] Basic15_textsArray = {
    "adventure. \n<color=red> aventura.",
    "walk. \n<color=red> paseo.",
    "zoo. \n<color=red> zoológico.",
    "mountain. \n<color=red> montaña.",
    "picnic. \n<color=red> picnic."
};

    public string[] Basic16_textsArray = {
    "traditions. \n<color=red> tradiciones.",
    "movies. \n<color=red> películas.",
    "music. \n<color=red> música.",
    "books. \n<color=red> libros.",
    "festival. \n<color=red> festival."
};

    public string[] Basic17_textsArray = {
    "walk. \n<color=red> paseo.",
    "picnic. \n<color=red> picnic.",
    "play. \n<color=red> juego.",
    "exploring. \n<color=red> exploración.",
    "camping. \n<color=red> camping."
};

    public string[] Basic18_textsArray = {
    "museum. \n<color=red> museo.",
    "buildings. \n<color=red> edificios.",
    "stories. \n<color=red> historias.",
    "documentaries. \n<color=red> documentales.",
    "book. \n<color=red> libro."
};

    public string[] Basic19_textsArray = {
    "break. \n<color=red> descanso.",
    "music. \n<color=red> música.",
    "bath. \n<color=red> baño.",
    "hammock. \n<color=red> hamaca.",
    "night. \n<color=red> noche."
};

    public string[] Basic20_textsArray = {
    "meal. \n<color=red> comida.",
    "pizza. \n<color=red> pizza.",
    "cookies. \n<color=red> galletas.",
    "cuisine. \n<color=red> cocina.",
    "class. \n<color=red> clase."
};

    public string[] Basic21_textsArray = {
    "neighborhood. \n<color=red> vecindario.",
    "recommendations. \n<color=red> recomendaciones.",
    "cafes. \n<color=red> cafés.",
    "exploration. \n<color=red> exploración.",
    "hike. \n<color=red> caminata."
};







    public string[] Basic22_textsArray = {
    "walk. \n<color=red> paseo.",
    "exercises. \n<color=red> ejercicios.",
    "dancing. \n<color=red> baile.",
    "jogging. \n<color=red> carrera.",
    "class. \n<color=red> clase."
};

    public string[] Basic23_textsArray = {
    "meal. \n<color=red> comida.",
    "snack. \n<color=red> refrigerio.",
    "cooking. \n<color=red> cocina.",
    "drinks. \n<color=red> bebidas.",
    "meals. \n<color=red> comidas."
};

    public string[] Basic24_textsArray = {
    "time. \n<color=red> tiempo.",
    "exercises. \n<color=red> ejercicios.",
    "meditating. \n<color=red> meditación.",
    "counselor. \n<color=red> consejero.",
    "activities. \n<color=red> actividades."
};

    public string[] Basic25_textsArray = {
    "routine. \n<color=red> rutina.",
    "lights. \n<color=red> luces.",
    "book. \n<color=red> libro.",
    "schedule. \n<color=red> horario.",
    "techniques. \n<color=red> técnicas."
};

    public string[] Basic26_textsArray = {
    "hands. \n<color=red> manos.",
    "vaccination. \n<color=red> vacunación.",
    "habits. \n<color=red> hábitos.",
    "diet. \n<color=red> dieta.",
    "home. \n<color=red> casa."
};

    public string[] Basic27_textsArray = {
    "activity. \n<color=red> actividad.",
    "diet. \n<color=red> dieta.",
    "time. \n<color=red> tiempo.",
    "self-care. \n<color=red> cuidado personal.",
    "aging. \n<color=red> envejecimiento."
};

    public string[] Basic28_textsArray = {
    "exercises. \n<color=red> ejercicios.",
    "intensity. \n<color=red> intensidad.",
    "activities. \n<color=red> actividades.",
    "goals. \n<color=red> objetivos.",
    "buddy. \n<color=red> compañero."
};











    public string[] Basic29_textsArray = {
    "things. \n<color=red> cosas.",
    "Reading. \n<color=red> Lectura.",
    "questions. \n<color=red> preguntas.",
    "Practice. \n<color=red> práctica.",
    "Education. \n<color=red> educación.",
};

    public string[] Basic30_textsArray = {
    "Study. \n<color=red> estudio.",
    "colleges. \n<color=red> universidades.",
    "College. \n<color=red> universidad.",
    "scholarships. \n<color=red> becas.",
    "yourself. \n<color=red> tú mismo.",
};

    public string[] Basic31_textsArray = {
    "library. \n<color=red> biblioteca.",
    "Libraries. \n<color=red> bibliotecas.",
    "Reading. \n<color=red> Lectura.",
    "book club. \n<color=red> club de lectura.",
    "Volunteer. \n<color=red> voluntario.",
};

    public string[] Basic32_textsArray = {
    "exams. \n<color=red> exámenes.",
    "breaks. \n<color=red> descansos.",
    "confidence. \n<color=red> confianza.",
    "friends. \n<color=red> amigos.",
    "Sleep. \n<color=red> sueño.",
};

    public string[] Basic33_textsArray = {
    "class. \n<color=red> clase.",
    "notes. \n<color=red> notas.",
    "questions. \n<color=red> preguntas.",
    "classmates. \n<color=red> compañeros de clase.",
    "organization. \n<color=red> organización.",
};

    public string[] Basic34_textsArray = {
    "professors. \n<color=red> profesores.",
    "office hours. \n<color=red> horas de oficina.",
    "feedback. \n<color=red> retroalimentación.",
    "class. \n<color=red> clase.",
    "professors. \n<color=red> profesores.",
};

    public string[] Basic35_textsArray = {
    "topics. \n<color=red> temas.",
    "sources. \n<color=red> fuentes.",
    "ideas. \n<color=red> ideas.",
    "peers. \n<color=red> compañeros.",
    "findings. \n<color=red> hallazgos.",
};








    public string[] Basic36_textsArray = {
    "job. \n<color=red> trabajo.",
    "customers. \n<color=red> clientes.",
    "money. \n<color=red> dinero.",
    "office. \n<color=red> oficina.",
    "challenge. \n<color=red> desafío.",
};

    public string[] Basic37_textsArray = {
    "construction. \n<color=red> construcción.",
    "gear. \n<color=red> equipo.",
    "projects. \n<color=red> proyectos.",
    "conditions. \n<color=red> condiciones.",
    "skills. \n<color=red> habilidades.",
};

    public string[] Basic38_textsArray = {
    "wage. \n<color=red> salario.",
    "effort. \n<color=red> esfuerzo.",
    "variations. \n<color=red> variaciones.",
    "savings. \n<color=red> ahorro.",
    "negotiation. \n<color=red> negociación.",
};

    public string[] Basic39_textsArray = {
    "building. \n<color=red> edificio.",
    "facilities. \n<color=red> instalaciones.",
    "organization. \n<color=red> organización.",
    "desk. \n<color=red> escritorio.",
    "collaboration. \n<color=red> colaboración.",
};

    public string[] Basic40_textsArray = {
    "store. \n<color=red> tienda.",
    "assistance. \n<color=red> ayuda.",
    "pace. \n<color=red> ritmo.",
    "transactions. \n<color=red> transacciones.",
    "promotions. \n<color=red> promociones.",
};

    public string[] Basic41_textsArray = {
    "nurse. \n<color=red> enfermera.",
    "departments. \n<color=red> departamentos.",
    "challenge. \n<color=red> desafío.",
    "care. \n<color=red> cuidado.",
    "hours. \n<color=red> horas.",
};

    public string[] Basic42_textsArray = {
    "bank. \n<color=red> banco.",
    "services. \n<color=red> servicios.",
    "transactions. \n<color=red> transacciones.",
    "detail. \n<color=red> detalle.",
    "security. \n<color=red> seguridad.",
};



    public string[] Basic43_textsArray = {
    "beach. \n<color=red> playa.",
    "sand. \n<color=red> arena.",
    "umbrellas. \n<color=red> sombrillas.",
    "destination. \n<color=red> destino.",
    "sunset. \n<color=red> puesta de sol.",
};

    public string[] Basic44_textsArray = {
    "picnics. \n<color=red> picnics.",
    "trees. \n<color=red> árboles.",
    "families. \n<color=red> familias.",
    "peace. \n<color=red> paz.",
    "concerts. \n<color=red> conciertos.",
};

    public string[] Basic45_textsArray = {
    "sports. \n<color=red> deportes.",
    "capacity. \n<color=red> capacidad.",
    "fans. \n<color=red> aficionados.",
    "excitement. \n<color=red> emoción.",
    "lights. \n<color=red> luces.",
};

    public string[] Basic46_textsArray = {
    "parties. \n<color=red> fiestas.",
    "music. \n<color=red> música.",
    "guests. \n<color=red> invitados.",
    "tradition. \n<color=red> tradición.",
    "friends. \n<color=red> amigos.",
};

    public string[] Basic47_textsArray = {
    "dining. \n<color=red> cena.",
    "dishes. \n<color=red> platos.",
    "menu. \n<color=red> menú.",
    "occasion. \n<color=red> ocasión.",
    "service. \n<color=red> servicio.",
};

    public string[] Basic48_textsArray = {
    "internet. \n<color=red> internet.",
    "access. \n<color=red> acceso.",
    "activities. \n<color=red> actividades.",
    "learning. \n<color=red> aprendizaje.",
    "safety. \n<color=red> seguridad.",
};

    public string[] Basic49_textsArray = {
    "movies. \n<color=red> películas.",
    "worlds. \n<color=red> mundos.",
    "theater. \n<color=red> teatro.",
    "entertainment. \n<color=red> entretenimiento.",
    "friends. \n<color=red> amigos.",
};






























    /// <summary>
    /// //////////////////////////////////////
    /// 
    ///  public string[] Rumor1_textsArray = {"My house is big. \n<color=red> Mi casa es grande.",  "I have a dog. \n<color=red> Tengo un perro.",  "The kitchen is yellow. \n<color=red> La cocina es amarilla.",  "I sleep in my bedroom. \n<color=red> Duermo en mi habitación.",  "The living room has a sofa. \n<color=red> El salón tiene un sofá."};

/// </summary>























public string[] Full1_textsArray = {
    "My house is big. \n<color=red> Mi casa es grande.",  "I have a dog. \n<color=red> Tengo un perro.",  "The kitchen is yellow. \n<color=red> La cocina es amarilla.",  "I sleep in my bedroom. \n<color=red> Duermo en mi habitación.",  "The living room has a sofa. \n<color=red> El salón tiene un sofá."};

    public string[] Full2_textsArray = { "The chair is red. \n<color=red> La silla es roja.", "The table is round. \n<color=red> La mesa es redonda.", "The bed is big. \n<color=red> La cama es grande.", "The lamp is on. \n<color=red> La lámpara está encendida.", "The sofa is comfortable. \n<color=red> El sofá es cómodo." };

    public string[] Full3_textsArray = {
    "The backyard is big. \n<color=red> El patio trasero es grande.",
    "We have flowers in the backyard. \n<color=red> Tenemos flores en el patio trasero.",
    "There is a swing in the backyard. \n<color=red> Hay un columpio en el patio trasero.",
    "We plant vegetables in the backyard. \n<color=red> Plantamos verduras en el patio trasero.",
    "We have a dog in the backyard. \n<color=red> Tenemos un perro en el patio trasero."
};
    public string[] Full4_textsArray = {
    "My mom is kind. \n<color=red> Mi mamá es amable.",
    "My dad is tall. \n<color=red> Mi papá es alto.",
    "My sister is funny. \n<color=red> Mi hermana es divertida.",
    "My brother is smart. \n<color=red> Mi hermano es inteligente.",
    "I love my grandparents. \n<color=red> Amo a mis abuelos."
};
    public string[] Full5_textsArray = {
    "The light is on. \n<color=red> La luz está encendida.",
    "The water is cold. \n<color=red> El agua está fría.",
    "The heater is broken. \n<color=red> La calefacción está rota.",
    "The air conditioner is loud. \n<color=red> El aire acondicionado hace mucho ruido.",
    "The internet is slow. \n<color=red> El internet está lento."
};
    public string[] Full6_textsArray = {
    "The picture is pretty. \n<color=red> El cuadro es bonito.",
    "Flowers are in the vase. \n<color=red> Hay flores en el jarrón.",
    "Curtains are white. \n<color=red> Las cortinas son blancas.",
    "The rug is big. \n<color=red> La alfombra es grande.",
    "Pillows are soft. \n<color=red> Los cojines son suaves."
};
    public string[] Full7_textsArray = {
    "The door squeaks. \n<color=red> La puerta chirría.",
    "The window is broken. \n<color=red> La ventana está rota.",
    "The wall needs painting. \n<color=red> La pared necesita ser pintada.",
    "The floor is dirty. \n<color=red> El suelo está sucio.",
    "The roof has a leak. \n<color=red> El techo tiene una filtración."
};


    public string[] Full8_textsArray = {
    "Let's go on an adventure. \n<color=red> Vamos a una aventura.",
    "We can take a walk in the park. \n<color=red> Podemos dar un paseo en el parque.",
    "She likes to visit the zoo. \n<color=red> A ella le gusta visitar el zoológico.",
    "He wants to climb a mountain. \n<color=red> Él quiere escalar una montaña.",
    "I'm planning a picnic in the countryside. \n<color=red> Estoy planeando un picnic en el campo.",
};

    public string[] Full9_textsArray = {
    "Let's learn about different traditions. \n<color=red> Aprendamos sobre diferentes tradiciones.",
    "We can watch movies from around the world. \n<color=red> Podemos ver películas de todo el mundo.",
    "She enjoys listening to music from different countries. \n<color=red> A ella le gusta escuchar música de diferentes países.",
    "He likes to read books about history. \n<color=red> A él le gusta leer libros sobre historia.",
    "I'm going to a cultural festival. \n<color=red> Voy a un festival cultural.",
};

    public string[] Full10_textsArray = {
    "Let's take a walk in the forest. \n<color=red> Vamos a dar un paseo por el bosque.",
    "We can have a picnic by the lake. \n<color=red> Podemos hacer un picnic junto al lago.",
    "She loves to play outside. \n<color=red> A ella le encanta jugar afuera.",
    "He enjoys exploring parks. \n<color=red> A él le gusta explorar parques.",
    "I'm going camping with my family. \n<color=red> Voy de camping con mi familia.",
};

    public string[] Full11_textsArray = {
    "Let's visit a museum. \n<color=red> Vamos a visitar un museo.",
    "We can explore old buildings. \n<color=red> Podemos explorar edificios antiguos.",
    "She enjoys hearing stories from her grandparents. \n<color=red> A ella le gusta escuchar historias de sus abuelos.",
    "He likes to watch documentaries about ancient civilizations. \n<color=red> A él le gusta ver documentales sobre civilizaciones antiguas.",
    "I'm reading a book about famous events in history. \n<color=red> Estoy leyendo un libro sobre eventos famosos en la historia.",
};

    public string[] Full12_textsArray = {
    "Let's take a break and relax in the garden. \n<color=red> Tomemos un descanso y relajémonos en el jardín.",
    "We can listen to calm music. \n<color=red> Podemos escuchar música tranquila.",
    "She enjoys taking a bubble bath. \n<color=red> A ella le gusta tomar un baño de burbujas.",
    "He likes to lie in a hammock. \n<color=red> A él le gusta acostarse en una hamaca.",
    "I'm going to have a movie night. \n<color=red> Voy a tener una noche de películas.",
};

    public string[] Full13_textsArray = {
    "Let's cook a simple meal together. \n<color=red> Cocinemos una comida sencilla juntos.",
    "We can try making homemade pizza. \n<color=red> Podemos intentar hacer pizza casera.",
    "She likes baking cookies. \n<color=red> A ella le gusta hornear galletas.",
    "He enjoys tasting different types of cuisine. \n<color=red> A él le gusta probar diferentes tipos de cocina.",
    "I'm attending a cooking class. \n<color=red> Voy a una clase de cocina.",
};

    public string[] Full14_textsArray = {
    "Let's explore the neighborhood. \n<color=red> Vamos a explorar el vecindario.",
    "We can ask locals for recommendations. \n<color=red> Podemos pedir recomendaciones a los lugareños.",
    "She enjoys discovering cozy cafes. \n<color=red> A ella le gusta descubrir cafés acogedores.",
    "He's passionate about urban exploration. \n<color=red> Él está apasionado por la exploración urbana.",
    "I'm going on a nature hike. \n<color=red> Voy a hacer una caminata por la naturaleza.",
};












    public string[] Full15_textsArray = {
    "Let's go on an adventure. \n<color=red> Vamos a una aventura.",
    "We can take a walk in the park. \n<color=red> Podemos dar un paseo en el parque.",
    "She likes to visit the zoo. \n<color=red> A ella le gusta visitar el zoológico.",
    "He wants to climb a mountain. \n<color=red> Él quiere escalar una montaña.",
    "I'm planning a picnic in the countryside. \n<color=red> Estoy planeando un picnic en el campo.",
};

    public string[] Full16_textsArray = {
    "Let's learn about different traditions. \n<color=red> Aprendamos sobre diferentes tradiciones.",
    "We can watch movies from around the world. \n<color=red> Podemos ver películas de todo el mundo.",
    "She enjoys listening to music from different countries. \n<color=red> A ella le gusta escuchar música de diferentes países.",
    "He likes to read books about history. \n<color=red> A él le gusta leer libros sobre historia.",
    "I'm going to a cultural festival. \n<color=red> Voy a un festival cultural.",
};

    public string[] Full17_textsArray = {
    "Let's take a walk in the forest. \n<color=red> Vamos a dar un paseo por el bosque.",
    "We can have a picnic by the lake. \n<color=red> Podemos hacer un picnic junto al lago.",
    "She loves to play outside. \n<color=red> A ella le encanta jugar afuera.",
    "He enjoys exploring parks. \n<color=red> A él le gusta explorar parques.",
    "I'm going camping with my family. \n<color=red> Voy de camping con mi familia.",
};

    public string[] Full18_textsArray = {
    "Let's visit a museum. \n<color=red> Vamos a visitar un museo.",
    "We can explore old buildings. \n<color=red> Podemos explorar edificios antiguos.",
    "She enjoys hearing stories from her grandparents. \n<color=red> A ella le gusta escuchar historias de sus abuelos.",
    "He likes to watch documentaries about ancient civilizations. \n<color=red> A él le gusta ver documentales sobre civilizaciones antiguas.",
    "I'm reading a book about famous events in history. \n<color=red> Estoy leyendo un libro sobre eventos famosos en la historia.",
};

    public string[] Full19_textsArray = {
    "Let's take a break and relax in the garden. \n<color=red> Tomemos un descanso y relajémonos en el jardín.",
    "We can listen to calm music. \n<color=red> Podemos escuchar música tranquila.",
    "She enjoys taking a bubble bath. \n<color=red> A ella le gusta tomar un baño de burbujas.",
    "He likes to lie in a hammock. \n<color=red> A él le gusta acostarse en una hamaca.",
    "I'm going to have a movie night. \n<color=red> Voy a tener una noche de películas.",
};

    public string[] Full20_textsArray = {
    "Let's cook a simple meal together. \n<color=red> Cocinemos una comida sencilla juntos.",
    "We can try making homemade pizza. \n<color=red> Podemos intentar hacer pizza casera.",
    "She likes baking cookies. \n<color=red> A ella le gusta hornear galletas.",
    "He enjoys tasting different types of cuisine. \n<color=red> A él le gusta probar diferentes tipos de cocina.",
    "I'm attending a cooking class. \n<color=red> Voy a una clase de cocina.",
};

    public string[] Full21_textsArray = {
    "Let's explore the neighborhood. \n<color=red> Vamos a explorar el vecindario.",
    "We can ask locals for recommendations. \n<color=red> Podemos pedir recomendaciones a los lugareños.",
    "She enjoys discovering cozy cafes. \n<color=red> A ella le gusta descubrir cafés acogedores.",
    "He's passionate about urban exploration. \n<color=red> Él está apasionado por la exploración urbana.",
    "I'm going on a nature hike. \n<color=red> Voy a hacer una caminata por la naturaleza.",
};









    public string[] Full22_textsArray = {
    "Let's go for a walk in the park. \n<color=red> Vamos a dar un paseo por el parque.",
    "We can do some stretching exercises. \n<color=red> Podemos hacer algunos ejercicios de estiramiento.",
    "She enjoys dancing to her favorite music. \n<color=red> A ella le gusta bailar con su música favorita.",
    "He wants to start jogging in the mornings. \n<color=red> Él quiere empezar a correr por las mañanas.",
    "I'm going to join a fitness class. \n<color=red> Voy a unirme a una clase de fitness.",
};

    public string[] Full23_textsArray = {
    "Let's eat a balanced meal with plenty of fruits and vegetables. \n<color=red> Vamos a comer una comida balanceada con muchas frutas y verduras.",
    "We can prepare a nutritious snack like yogurt with granola. \n<color=red> Podemos preparar un refrigerio nutritivo como yogur con granola.",
    "She enjoys cooking healthy meals with fresh ingredients. \n<color=red> A ella le gusta cocinar comidas saludables con ingredientes frescos.",
    "He wants to cut back on sugary drinks. \n<color=red> Él quiere reducir el consumo de bebidas azucaradas.",
    "I'm going to plan my meals ahead of time. \n<color=red> Voy a planificar mis comidas con anticipación.",
};

    public string[] Full24_textsArray = {
    "Let's take some time to relax and unwind after a busy day. \n<color=red> Vamos a tomar un tiempo para relajarnos después de un día ocupado.",
    "We can practice deep breathing exercises to calm our minds. \n<color=red> Podemos practicar ejercicios de respiración profunda para calmar nuestras mentes.",
    "She enjoys meditating to reduce stress and anxiety. \n<color=red> A ella le gusta meditar para reducir el estrés y la ansiedad.",
    "He wants to talk to a counselor about managing his emotions. \n<color=red> Él quiere hablar con un consejero sobre cómo manejar sus emociones.",
    "I'm going to spend some time doing activities I enjoy. \n<color=red> Voy a pasar un tiempo haciendo actividades que me gustan.",
};

    public string[] Full25_textsArray = {
    "Let's create a relaxing bedtime routine to help us sleep better. \n<color=red> Vamos a crear una rutina relajante antes de dormir para ayudarnos a dormir mejor.",
    "We can avoid screens and bright lights before bedtime. \n<color=red> Podemos evitar las pantallas y las luces brillantes antes de acostarnos.",
    "She enjoys reading a book in bed to wind down before sleeping. \n<color=red> A ella le gusta leer un libro en la cama para relajarse antes de dormir.",
    "He wants to set a consistent sleep schedule. \n<color=red> Él quiere establecer un horario de sueño consistente.",
    "I'm going to try relaxation techniques like listening to calming music. \n<color=red> Voy a probar técnicas de relajación como escuchar música tranquila.",
};

    public string[] Full26_textsArray = {
    "Let's wash our hands frequently to prevent the spread of germs. \n<color=red> Vamos a lavarnos las manos con frecuencia para prevenir la propagación de gérmenes.",
    "We can get vaccinated to protect ourselves against infectious diseases. \n<color=red> Podemos vacunarnos para protegernos contra enfermedades infecciosas.",
    "She practices good hygiene habits. \n<color=red> A ella le gusta practicar buenos hábitos de higiene.",
    "He wants to eat a balanced diet. \n<color=red> Él quiere comer una dieta balanceada.",
    "I'm going to stay home when I'm sick. \n<color=red> Voy a quedarme en casa cuando esté enfermo.",
};

    public string[] Full27_textsArray = {
    "Let's stay active and exercise regularly. \n<color=red> Vamos a mantenernos activos y hacer ejercicio regularmente.",
    "We can eat a healthy diet with plenty of nutrients. \n<color=red> Podemos comer una dieta saludable con muchos nutrientes.",
    "She enjoys spending time with loved ones. \n<color=red> A ella le gusta pasar tiempo con sus seres queridos.",
    "He wants to prioritize self-care and relaxation. \n<color=red> Él quiere priorizar el cuidado personal y la relajación.",
    "I'm going to embrace aging as a natural part of life. \n<color=red> Voy a aceptar el envejecimiento como una parte natural de la vida.",
};

    public string[] Full28_textsArray = {
    "Let's start with simple exercises like walking or jogging. \n<color=red> Comencemos con ejercicios simples como caminar o correr.",
    "We can gradually increase the intensity of our workouts. \n<color=red> Podemos aumentar gradualmente la intensidad de nuestros entrenamientos.",
    "She enjoys trying new fitness activities like yoga or Pilates. \n<color=red> A ella le gusta probar nuevas actividades de fitness como yoga o Pilates.",
    "He wants to set specific fitness goals. \n<color=red> Él quiere establecer objetivos de fitness específicos.",
    "I'm going to find a workout buddy. \n<color=red> Voy a encontrar un compañero de entrenamiento.",
};










    public string[] Full29_textsArray = {
    "Let's learn new things every day! \n<color=red> ¡Aprendamos cosas nuevas todos los días!",
    "Reading is fun and helps us learn. \n<color=red> Leer es divertido y nos ayuda a aprender.",
    "Ask questions when you don't understand. \n<color=red> Haz preguntas cuando no entiendas.",
    "Practice makes perfect! \n<color=red> ¡La práctica hace al maestro!",
    "Education is the key to success. \n<color=red> La educación es la clave del éxito.",
};

    public string[] Full30_textsArray = {
    "Study hard to achieve your dreams! \n<color=red> ¡Estudia duro para alcanzar tus sueños!",
    "Explore different colleges and find your fit. \n<color=red> Explora diferentes universidades y encuentra la adecuada para ti.",
    "College is a time for growth and discovery. \n<color=red> La universidad es un momento de crecimiento y descubrimiento.",
    "Apply for scholarships to help pay for tuition. \n<color=red> Solicita becas para ayudar a pagar la matrícula.",
    "Believe in yourself and your abilities. \n<color=red> Cree en ti mismo y en tus habilidades.",
};

    public string[] Full31_textsArray = {
    "Visit the library for books and quiet study. \n<color=red> Visita la biblioteca para libros y estudiar en silencio.",
    "Libraries offer resources for research and learning. \n<color=red> Las bibliotecas ofrecen recursos para investigación y aprendizaje.",
    "Reading opens doors to new worlds and ideas. \n<color=red> Leer abre puertas a nuevos mundos e ideas.",
    "Join a book club for discussion and friendship. \n<color=red> Únete a un club de lectura para discusión y amistad.",
    "Volunteer at the library to give back to the community. \n<color=red> Haz trabajo voluntario en la biblioteca para devolver a la comunidad.",
};

    public string[] Full32_textsArray = {
    "Prepare for exams by studying and reviewing. \n<color=red> Prepárate para los exámenes estudiando y revisando.",
    "Take breaks while studying to stay focused. \n<color=red> Toma descansos mientras estudias para mantenerte concentrado.",
    "Stay calm and confident during exams. \n<color=red> Mantén la calma y la confianza durante los exámenes.",
    "Study with friends for motivation and support. \n<color=red> Estudia con amigos para motivación y apoyo.",
    "Sleep well before exams for a clear mind. \n<color=red> Duerme bien antes de los exámenes para una mente clara.",
};

    public string[] Full33_textsArray = {
    "Participate in class discussions and activities. \n<color=red> Participa en las discusiones y actividades de clase.",
    "Take notes to remember important information. \n<color=red> Toma notas para recordar la información importante.",
    "Ask questions when you're unsure. \n<color=red> Haz preguntas cuando no estés seguro.",
    "Respect your classmates and their opinions. \n<color=red> Respeta a tus compañeros y sus opiniones.",
    "Stay organized with your schoolwork and assignments. \n<color=red> Mantente organizado con tus tareas y deberes escolares.",
};

    public string[] Full34_textsArray = {
    "Listen to your professors and learn from their experience. \n<color=red> Escucha a tus profesores y aprende de su experiencia.",
    "Attend office hours for extra help and guidance. \n<color=red> Asiste a las horas de oficina para ayuda y orientación adicional.",
    "Ask for feedback to improve your work. \n<color=red> Pide retroalimentación para mejorar tu trabajo.",
    "Be respectful and courteous in class. \n<color=red> Sé respetuoso y cortés en clase.",
    "Thank your professors for their dedication and support. \n<color=red> Agradece a tus profesores por su dedicación y apoyo.",
};

    public string[] Full35_textsArray = {
    "Explore different topics and research areas. \n<color=red> Explora diferentes temas y áreas de investigación.",
    "Use reliable sources for your research. \n<color=red> Usa fuentes confiables para tu investigación.",
    "Experiment with new ideas and methods. \n<color=red> Experimenta con nuevas ideas y métodos.",
    "Collaborate with peers for diverse perspectives. \n<color=red> Colabora con tus compañeros para obtener perspectivas diversas.",
    "Share your findings with others to contribute to knowledge. \n<color=red> Comparte tus hallazgos con otros para contribuir al conocimiento.",
};












    public string[] Full36_textsArray = {
    "I have a job at the store. \n<color=red> Tengo un trabajo en la tienda.",
    "My job is to help customers. \n<color=red> Mi trabajo es ayudar a los clientes.",
    "I earn money to buy things. \n<color=red> Gano dinero para comprar cosas.",
    "Working at the office is enjoyable. \n<color=red> Trabajar en la oficina es agradable.",
    "I like my job because it challenges me. \n<color=red> Me gusta mi trabajo porque me desafía.",
};

    public string[] Full37_textsArray = {
    "Construction workers build houses. \n<color=red> Los trabajadores de la construcción construyen casas.",
    "Safety gear is important on the job. \n<color=red> El equipo de seguridad es importante en el trabajo.",
    "Construction projects take time to complete. \n<color=red> Los proyectos de construcción llevan tiempo completarse.",
    "Construction workers work in different weather conditions. \n<color=red> Los trabajadores de la construcción trabajan en diferentes condiciones climáticas.",
    "Learning new skills is part of the job. \n<color=red> Aprender nuevas habilidades es parte del trabajo.",
};

    public string[] Full38_textsArray = {
    "I receive my wage every month. \n<color=red> Recibo mi salario cada mes.",
    "I work hard to earn my wage. \n<color=red> Trabajo duro para ganar mi salario.",
    "Wages vary depending on the job. \n<color=red> Los salarios varían según el trabajo.",
    "Earning a good wage allows me to save money for the future. \n<color=red> Ganar un buen salario me permite ahorrar dinero para el futuro.",
    "Negotiating wages during a job interview is important. \n<color=red> Negociar salarios durante una entrevista de trabajo es importante.",
};

    public string[] Full39_textsArray = {
    "I work in an office building. \n<color=red> Trabajo en un edificio de oficinas.",
    "My office has a kitchen and a break room. \n<color=red> Mi oficina tiene una cocina y una sala de descanso.",
    "Working in an office requires good organizational skills. \n<color=red> Trabajar en una oficina requiere buenas habilidades organizativas.",
    "I have my own desk in the office. \n<color=red> Tengo mi propio escritorio en la oficina.",
    "Office workers often collaborate on projects. \n<color=red> Los trabajadores de oficina a menudo colaboran en proyectos.",
};

    public string[] Full40_textsArray = {
    "I work in a retail store. \n<color=red> Trabajo en una tienda minorista.",
    "I help customers find what they need. \n<color=red> Ayudo a los clientes a encontrar lo que necesitan.",
    "Working in retail can be fast-paced. \n<color=red> Trabajar en el comercio minorista puede ser rápido.",
    "Retail workers handle cash transactions. \n<color=red> Los trabajadores minoristas manejan transacciones en efectivo.",
    "Retail stores often have sales and promotions. \n<color=red> Las tiendas minoristas a menudo tienen ventas y promociones.",
};

    public string[] Full41_textsArray = {
    "I work at the hospital as a nurse. \n<color=red> Trabajo en el hospital como enfermera.",
    "The hospital has many departments like emergency and surgery. \n<color=red> El hospital tiene muchos departamentos como emergencia y cirugía.",
    "Working at the hospital can be challenging. \n<color=red> Trabajar en el hospital puede ser desafiante.",
    "Healthcare workers at the hospital provide compassionate care. \n<color=red> Los trabajadores de la salud en el hospital brindan atención compasiva.",
    "Hospital staff work long hours. \n<color=red> El personal del hospital trabaja largas horas.",
};

    public string[] Full42_textsArray = {
    "I work at the bank as a teller. \n<color=red> Trabajo en el banco como cajero.",
    "The bank offers services like loans and savings accounts. \n<color=red> El banco ofrece servicios como préstamos y cuentas de ahorro.",
    "Bank tellers handle financial transactions. \n<color=red> Los cajeros del banco manejan transacciones financieras.",
    "Working at the bank requires attention to detail. \n<color=red> Trabajar en el banco requiere atención a los detalles.",
    "Banks have strict security measures in place. \n<color=red> Los bancos tienen medidas de seguridad estrictas.",
};



    public string[] Full43_textsArray = {
    "I love going to the beach with my family. \n<color=red> Me encanta ir a la playa con mi familia.",
    "The beach has soft sand. \n<color=red> La playa tiene arena suave.",
    "People bring umbrellas and towels to the beach. \n<color=red> Las personas llevan sombrillas y toallas a la playa.",
    "The beach is a popular destination for tourists. \n<color=red> La playa es un destino popular para los turistas.",
    "Watching the sunset at the beach is a beautiful experience. \n<color=red> Ver la puesta de sol en la playa es una experiencia hermosa.",
};

    public string[] Full44_textsArray = {
    "I enjoy picnics at the park with my friends. \n<color=red> Disfruto de los picnics en el parque con mis amigos.",
    "The park has tall trees and green grass. \n<color=red> El parque tiene árboles altos y césped verde.",
    "Families come to the park to relax and have fun. \n<color=red> Las familias vienen al parque para relajarse y divertirse.",
    "The park is a peaceful place to go for a walk. \n<color=red> El parque es un lugar tranquilo para dar un paseo.",
    "During the summer, the park hosts outdoor concerts. \n<color=red> Durante el verano, el parque alberga conciertos al aire libre.",
};

    public string[] Full45_textsArray = {
    "I enjoy watching sports games at the stadium with my friends. \n<color=red> Disfruto viendo juegos deportivos en el estadio con mis amigos.",
    "The stadium has a large seating capacity. \n<color=red> El estadio tiene una gran capacidad de asientos.",
    "Fans come to the stadium wearing team jerseys. \n<color=red> Los aficionados vienen al estadio vistiendo camisetas de equipo.",
    "Watching a live game at the stadium is exciting. \n<color=red> Ver un juego en vivo en el estadio es emocionante.",
    "The stadium lights up at night during evening games. \n<color=red> El estadio se ilumina por la noche durante los juegos nocturnos.",
};

    public string[] Full46_textsArray = {
    "I enjoy going to parties with my friends. \n<color=red> Disfruto yendo a fiestas con mis amigos.",
    "Parties have music and decorations. \n<color=red> Las fiestas tienen música y decoraciones.",
    "Guests bring food and drinks to parties. \n<color=red> Los invitados traen comida y bebidas a las fiestas.",
    "Celebrating birthdays and holidays with parties is a tradition. \n<color=red> Celebrar cumpleaños y fiestas con fiestas es una tradición.",
    "The best part of a party is spending time with friends. \n<color=red> La mejor parte de una fiesta es pasar tiempo con amigos.",
};

    public string[] Full47_textsArray = {
    "I enjoy dining out at restaurants with my family. \n<color=red> Disfruto cenando en restaurantes con mi familia.",
    "Restaurants offer a variety of dishes. \n<color=red> Los restaurantes ofrecen una variedad de platos.",
    "Diners can choose from appetizers, main courses, and desserts on the menu. \n<color=red> Los comensales pueden elegir entre entrantes, platos principales y postres en el menú.",
    "Eating at a restaurant is a special occasion. \n<color=red> Comer en un restaurante es una ocasión especial.",
    "Restaurant staff provide excellent service. \n<color=red> El personal del restaurante ofrece un excelente servicio.",
};

    public string[] Full48_textsArray = {
    "I use the internet to stay connected with friends and family. \n<color=red> Uso internet para mantenerme conectado con amigos y familiares.",
    "The internet provides access to information and entertainment. \n<color=red> Internet proporciona acceso a información y entretenimiento.",
    "People use the internet for shopping, banking, and communication. \n<color=red> Las personas usan internet para comprar, hacer banca y comunicarse.",
    "Online learning and remote work have become more common with the use of the internet. \n<color=red> El aprendizaje en línea y el trabajo remoto se han vuelto más comunes con el uso de internet.",
    "Internet safety is important. \n<color=red> La seguridad en internet es importante.",
};

    public string[] Full49_textsArray = {
    "I enjoy watching movies at the theater with my friends. \n<color=red> Disfruto viendo películas en el cine con mis amigos.",
    "Movies transport viewers to different worlds and tell captivating stories. \n<color=red> Las películas transportan a los espectadores a diferentes mundos y cuentan historias cautivadoras.",
    "The movie theater has comfortable seats and a big screen. \n<color=red> El cine tiene asientos cómodos y una pantalla grande.",
    "People enjoy going to the movies for entertainment and relaxation. \n<color=red> A la gente le gusta ir al cine para entretenerse y relajarse.",
    "Watching a movie with friends or family is a fun way to spend time together. \n<color=red> Ver una película con amigos o familiares es una forma divertida de pasar tiempo juntos.",
};






















    //////////////////////////////////////






    public string[] Compound1_textsArray = {
    "My house is big, and it has a beautiful garden. \n<color=red> Mi casa es grande, y tiene un jardín hermoso.",  "I have a dog, and my neighbor has a cat. \n<color=red> Tengo un perro, y mi vecino tiene un gato.",  "The kitchen is yellow, but the living room is blue. \n<color=red> La cocina es amarilla, pero el salón es azul.",  "I sleep in my bedroom, and my sister sleeps in hers. \n<color=red> Duermo en mi habitación, y mi hermana duerme en la suya.",  "The living room has a sofa, and there are two chairs next to it. \n<color=red> El salón tiene un sofá, y hay dos sillas al lado."};

    public string[] Compound2_textsArray = { "The chair is red, and it matches the curtains. \n<color=red> La silla es roja, y combina con las cortinas.", "The table is round, and it can seat four people. \n<color=red> La mesa es redonda, y puede acomodar a cuatro personas.", "The bed is big, and it has four pillows. \n<color=red> La cama es grande, y tiene cuatro almohadas.", "The lamp is on, and it gives warm light. \n<color=red> La lámpara está encendida, y da una luz cálida.", "The sofa is comfortable, and we sit there to watch TV. \n<color=red> El sofá es cómodo, y nos sentamos allí para ver la televisión." };

    public string[] Compound3_textsArray = {
        "The backyard is big, and there is a tree where birds sing. \n<color=red> El patio trasero es grande, y hay un árbol donde los pájaros cantan.",      "We have flowers in the backyard, and they smell really nice. \n<color=red> Tenemos flores en el patio trasero, y huelen muy bien.",      "There is a swing in the backyard, and we play on it every day. \n<color=red> Hay un columpio en el patio trasero, y jugamos en él todos los días.",      "We plant vegetables in the backyard, and we eat them for dinner. \n<color=red> Plantamos verduras en el patio trasero, y las comemos para cenar.",    "We have a dog in the backyard, and it loves to run around. \n<color=red> Tenemos un perro en el patio trasero, y le encanta correr por ahí."  };
    public string[] Compound4_textsArray = {
        "My mom is kind, and she always helps me with my homework. \n<color=red> Mi mamá es amable, y siempre me ayuda con mi tarea.",      "My dad is tall, but my uncle is taller. \n<color=red> Mi papá es alto, pero mi tío es más alto.",   "My sister is funny, and she makes me laugh every day. \n<color=red> Mi hermana es divertida, y me hace reír todos los días.",  "My brother is smart, and he gets good grades in school. \n<color=red> Mi hermano es inteligente, y saca buenas notas en la escuela.",    "I love my grandparents, and we visit them on weekends. \n<color=red> Amo a mis abuelos, y los visitamos los fines de semana."  };
    public string[] Compound5_textsArray = {
        "The light is on, but we need to save electricity. \n<color=red> La luz está encendida, pero necesitamos ahorrar electricidad.",    "The water is cold, so I'm going to take a warm shower. \n<color=red> El agua está fría, así que voy a tomar una ducha caliente.",    "The heater is broken, but we have blankets to keep us warm. \n<color=red> La calefacción está rota, pero tenemos mantas para mantenernos calientes.",    "The air conditioner is loud, but it's too hot to turn it off. \n<color=red> El aire acondicionado hace mucho ruido, pero hace demasiado calor para apagarlo.",    "The internet is slow, so I can't watch videos online. \n<color=red> El internet está lento, así que no puedo ver videos en línea."};
    public string[] Compound6_textsArray = {
    "The picture is pretty and on the wall. \n<color=red> El cuadro es bonito y está en la pared.",    "Flowers are in the vase and look fresh. \n<color=red> Hay flores en el jarrón y se ven frescas.",   "Curtains are white and clean. \n<color=red> Las cortinas son blancas y limpias.",    "The rug is big and under the table. \n<color=red> La alfombra es grande y está debajo de la mesa.",    "Pillows are soft and on the bed. \n<color=red> Los cojines son suaves y están en la cama."};
    public string[] Compound7_textsArray = {
    "The door squeaks, but we can fix it with some oil. \n<color=red> La puerta chirría, pero podemos arreglarlo con un poco de aceite.",  "The window is broken, and we need to replace the glass. \n<color=red> La ventana está rota, y necesitamos reemplazar el vidrio.", "The wall needs painting, so we'll buy some paint at the store. \n<color=red> La pared necesita ser pintada, así que compraremos pintura en la tienda.", "The floor is dirty, but we'll clean it with a mop. \n<color=red> El suelo está sucio, pero lo limpiaremos con una fregona.",   "The roof has a leak, and we'll patch it up with some sealant. \n<color=red> El techo tiene una filtración, y lo parchearemos con un sellador."};



    public string[] Compound8_textsArray = {
    "Let's go on an adventure and explore new places. \n<color=red> Vamos a una aventura y exploramos nuevos lugares.",
    "We can take a walk in the park and enjoy nature. \n<color=red> Podemos dar un paseo en el parque y disfrutamos de la naturaleza.",
    "She likes to visit the zoo and see the animals. \n<color=red> A ella le gusta visitar el zoológico y ver los animales.",
    "He wants to climb a mountain and see the view from the top. \n<color=red> Él quiere escalar una montaña y ver la vista desde arriba.",
    "I'm planning a picnic in the countryside with friends. \n<color=red> Estoy planeando un picnic en el campo con amigos.",
};

    public string[] Compound9_textsArray = {
    "Let's learn about different traditions and customs. \n<color=red> Aprendamos sobre diferentes tradiciones y costumbres.",
    "We can watch movies from around the world to learn about other cultures. \n<color=red> Podemos ver películas de todo el mundo para aprender sobre otras culturas.",
    "She enjoys listening to music from different countries. \n<color=red> A ella le gusta escuchar música de diferentes países.",
    "He likes to read books about history and famous people. \n<color=red> A él le gusta leer libros sobre historia y personas famosas.",
    "I'm going to a cultural festival to try new foods and see performances. \n<color=red> Voy a un festival cultural para probar comidas nuevas y ver actuaciones.",
};

    public string[] Compound10_textsArray = {
    "Let's take a walk in the forest and listen to the birds. \n<color=red> Vamos a dar un paseo por el bosque y escuchamos a los pájaros.",
    "We can have a picnic by the lake and enjoy the sunshine. \n<color=red> Podemos hacer un picnic junto al lago y disfrutamos del sol.",
    "She loves to play outside and feel the grass under her feet. \n<color=red> A ella le encanta jugar afuera y sentir la hierba bajo sus pies.",
    "He enjoys exploring parks and finding hidden trails. \n<color=red> A él le gusta explorar parques y encontrar senderos escondidos.",
    "I'm going camping with my family to see the stars at night. \n<color=red> Voy de camping con mi familia para ver las estrellas por la noche.",
};

    public string[] Compound11_textsArray = {
    "Let's visit a museum and learn about the past. \n<color=red> Vamos a visitar un museo y aprendemos sobre el pasado.",
    "We can explore old buildings and imagine life long ago. \n<color=red> Podemos explorar edificios antiguos e imaginar la vida hace mucho tiempo.",
    "She enjoys hearing stories from her grandparents about their childhood. \n<color=red> A ella le gusta escuchar historias de sus abuelos sobre su infancia.",
    "He likes to watch documentaries about ancient civilizations. \n<color=red> A él le gusta ver documentales sobre civilizaciones antiguas.",
    "I'm reading a book about famous events in history. \n<color=red> Estoy leyendo un libro sobre eventos famosos en la historia.",
};

    public string[] Compound12_textsArray = {
    "Let's take a break and relax in the garden. \n<color=red> Tomemos un descanso y relajémonos en el jardín.",
    "We can listen to calm music and take deep breaths. \n<color=red> Podemos escuchar música tranquila y tomar respiraciones profundas.",
    "She enjoys taking a bubble bath and reading a book. \n<color=red> A ella le gusta tomar un baño de burbujas y leer un libro.",
    "He likes to lie in a hammock and watch the clouds go by. \n<color=red> A él le gusta acostarse en una hamaca y ver pasar las nubes.",
    "I'm going to have a movie night with popcorn and cozy blankets. \n<color=red> Voy a tener una noche de películas con palomitas de maíz y mantas acogedoras.",
};

    public string[] Compound13_textsArray = {
    "Let's cook a simple meal together and enjoy it. \n<color=red> Cocinemos una comida sencilla juntos y la disfrutamos.",
    "We can try making homemade pizza with our favorite toppings. \n<color=red> Podemos intentar hacer pizza casera con nuestros ingredientes favoritos.",
    "She likes baking cookies and sharing them with friends. \n<color=red> A ella le gusta hornear galletas y compartirlas con amigos.",
    "He enjoys tasting different types of cuisine from around the world. \n<color=red> A él le gusta probar diferentes tipos de cocina de todo el mundo.",
    "I'm attending a cooking class to learn new recipes and techniques. \n<color=red> Voy a una clase de cocina para aprender nuevas recetas y técnicas.",
};

    public string[] Compound14_textsArray = {
    "Let's explore the neighborhood and find hidden treasures. \n<color=red> Vamos a explorar el vecindario y encontrar tesoros escondidos.",
    "We can ask locals for recommendations on hidden gems to visit. \n<color=red> Podemos pedir recomendaciones a los lugareños sobre joyas ocultas para visitar.",
    "She enjoys discovering cozy cafes and unique shops off the beaten path. \n<color=red> A ella le gusta descubrir cafés acogedores y tiendas únicas fuera del camino trillado.",
    "He's passionate about urban exploration and loves finding hidden gems in the city. \n<color=red> Él está apasionado por la exploración urbana y le encanta encontrar joyas ocultas en la ciudad.",
    "I'm going on a nature hike to uncover hidden gems in the wilderness. \n<color=red> Voy a hacer una caminata por la naturaleza para descubrir joyas ocultas en la naturaleza.",
};












    public string[] Compound15_textsArray = {
    "Let's go on an adventure and explore new places. \n<color=red> Vamos a una aventura y exploramos nuevos lugares.",
    "We can take a walk in the park and enjoy nature. \n<color=red> Podemos dar un paseo en el parque y disfrutamos de la naturaleza.",
    "She likes to visit the zoo and see the animals. \n<color=red> A ella le gusta visitar el zoológico y ver los animales.",
    "He wants to climb a mountain and see the view from the top. \n<color=red> Él quiere escalar una montaña y ver la vista desde arriba.",
    "I'm planning a picnic in the countryside with friends. \n<color=red> Estoy planeando un picnic en el campo con amigos.",
};

    public string[] Compound16_textsArray = {
    "Let's learn about different traditions and customs. \n<color=red> Aprendamos sobre diferentes tradiciones y costumbres.",
    "We can watch movies from around the world to learn about other cultures. \n<color=red> Podemos ver películas de todo el mundo para aprender sobre otras culturas.",
    "She enjoys listening to music from different countries. \n<color=red> A ella le gusta escuchar música de diferentes países.",
    "He likes to read books about history and famous people. \n<color=red> A él le gusta leer libros sobre historia y personas famosas.",
    "I'm going to a cultural festival to try new foods and see performances. \n<color=red> Voy a un festival cultural para probar comidas nuevas y ver actuaciones.",
};

    public string[] Compound17_textsArray = {
    "Let's take a walk in the forest and listen to the birds. \n<color=red> Vamos a dar un paseo por el bosque y escuchamos a los pájaros.",
    "We can have a picnic by the lake and enjoy the sunshine. \n<color=red> Podemos hacer un picnic junto al lago y disfrutamos del sol.",
    "She loves to play outside and feel the grass under her feet. \n<color=red> A ella le encanta jugar afuera y sentir la hierba bajo sus pies.",
    "He enjoys exploring parks and finding hidden trails. \n<color=red> A él le gusta explorar parques y encontrar senderos escondidos.",
    "I'm going camping with my family to see the stars at night. \n<color=red> Voy de camping con mi familia para ver las estrellas por la noche.",
};

    public string[] Compound18_textsArray = {
    "Let's visit a museum and learn about the past. \n<color=red> Vamos a visitar un museo y aprendemos sobre el pasado.",
    "We can explore old buildings and imagine life long ago. \n<color=red> Podemos explorar edificios antiguos e imaginar la vida hace mucho tiempo.",
    "She enjoys hearing stories from her grandparents about their childhood. \n<color=red> A ella le gusta escuchar historias de sus abuelos sobre su infancia.",
    "He likes to watch documentaries about ancient civilizations. \n<color=red> A él le gusta ver documentales sobre civilizaciones antiguas.",
    "I'm reading a book about famous events in history. \n<color=red> Estoy leyendo un libro sobre eventos famosos en la historia.",
};

    public string[] Compound19_textsArray = {
    "Let's take a break and relax in the garden. \n<color=red> Tomemos un descanso y relajémonos en el jardín.",
    "We can listen to calm music and take deep breaths. \n<color=red> Podemos escuchar música tranquila y tomar respiraciones profundas.",
    "She enjoys taking a bubble bath and reading a book. \n<color=red> A ella le gusta tomar un baño de burbujas y leer un libro.",
    "He likes to lie in a hammock and watch the clouds go by. \n<color=red> A él le gusta acostarse en una hamaca y ver pasar las nubes.",
    "I'm going to have a movie night with popcorn and cozy blankets. \n<color=red> Voy a tener una noche de películas con palomitas de maíz y mantas acogedoras.",
};

    public string[] Compound20_textsArray = {
    "Let's cook a simple meal together and enjoy it. \n<color=red> Cocinemos una comida sencilla juntos y la disfrutamos.",
    "We can try making homemade pizza with our favorite toppings. \n<color=red> Podemos intentar hacer pizza casera con nuestros ingredientes favoritos.",
    "She likes baking cookies and sharing them with friends. \n<color=red> A ella le gusta hornear galletas y compartirlas con amigos.",
    "He enjoys tasting different types of cuisine from around the world. \n<color=red> A él le gusta probar diferentes tipos de cocina de todo el mundo.",
    "I'm attending a cooking class to learn new recipes and techniques. \n<color=red> Voy a una clase de cocina para aprender nuevas recetas y técnicas.",
};

    public string[] Compound21_textsArray = {
    "Let's explore the neighborhood and find hidden treasures. \n<color=red> Vamos a explorar el vecindario y encontrar tesoros escondidos.",
    "We can ask locals for recommendations on hidden gems to visit. \n<color=red> Podemos pedir recomendaciones a los lugareños sobre joyas ocultas para visitar.",
    "She enjoys discovering cozy cafes and unique shops off the beaten path. \n<color=red> A ella le gusta descubrir cafés acogedores y tiendas únicas fuera del camino trillado.",
    "He's passionate about urban exploration and loves finding hidden gems in the city. \n<color=red> Él está apasionado por la exploración urbana y le encanta encontrar joyas ocultas en la ciudad.",
    "I'm going on a nature hike to uncover hidden gems in the wilderness. \n<color=red> Voy a hacer una caminata por la naturaleza para descubrir joyas ocultas en la naturaleza.",
};








    public string[] Compound22_textsArray = {
    "Let's go for a walk in the park to get some fresh air. \n<color=red> Vamos a dar un paseo por el parque para tomar aire fresco.",
    "We can do some stretching exercises to loosen up our muscles. \n<color=red> Podemos hacer algunos ejercicios de estiramiento para relajar nuestros músculos.",
    "She enjoys dancing to her favorite music for fun and exercise. \n<color=red> A ella le gusta bailar con su música favorita para divertirse y hacer ejercicio.",
    "He wants to start jogging in the mornings to improve his fitness. \n<color=red> Él quiere empezar a correr por las mañanas para mejorar su estado físico.",
    "I'm going to join a fitness class to stay active and healthy. \n<color=red> Voy a unirme a una clase de fitness para mantenerme activo y saludable.",
};

    public string[] Compound23_textsArray = {
    "Let's eat a balanced meal with plenty of fruits and vegetables. \n<color=red> Vamos a comer una comida balanceada con muchas frutas y verduras.",
    "We can prepare a nutritious snack like yogurt with granola. \n<color=red> Podemos preparar un refrigerio nutritivo como yogur con granola.",
    "She enjoys cooking healthy meals with fresh ingredients. \n<color=red> A ella le gusta cocinar comidas saludables con ingredientes frescos.",
    "He wants to cut back on sugary drinks and opt for water instead. \n<color=red> Él quiere reducir el consumo de bebidas azucaradas y optar por agua en su lugar.",
    "I'm going to plan my meals ahead of time to make healthier choices. \n<color=red> Voy a planificar mis comidas con anticipación para hacer elecciones más saludables.",
};

    public string[] Compound24_textsArray = {
    "Let's take some time to relax and unwind after a busy day. \n<color=red> Vamos a tomar un tiempo para relajarnos después de un día ocupado.",
    "We can practice deep breathing exercises to calm our minds. \n<color=red> Podemos practicar ejercicios de respiración profunda para calmar nuestras mentes.",
    "She enjoys meditating to reduce stress and anxiety. \n<color=red> A ella le gusta meditar para reducir el estrés y la ansiedad.",
    "He wants to talk to a counselor about managing his emotions. \n<color=red> Él quiere hablar con un consejero sobre cómo manejar sus emociones.",
    "I'm going to spend some time doing activities I enjoy to boost my mood. \n<color=red> Voy a pasar un tiempo haciendo actividades que me gustan para mejorar mi estado de ánimo.",
};

    public string[] Compound25_textsArray = {
    "Let's create a relaxing bedtime routine to help us sleep better. \n<color=red> Vamos a crear una rutina relajante antes de dormir para ayudarnos a dormir mejor.",
    "We can avoid screens and bright lights before bedtime to promote sleep. \n<color=red> Podemos evitar las pantallas y las luces brillantes antes de acostarnos para promover el sueño.",
    "She enjoys reading a book in bed to wind down before sleeping. \n<color=red> A ella le gusta leer un libro en la cama para relajarse antes de dormir.",
    "He wants to set a consistent sleep schedule to improve his sleep quality. \n<color=red> Él quiere establecer un horario de sueño consistente para mejorar la calidad de su sueño.",
    "I'm going to try relaxation techniques like listening to calming music to help me sleep. \n<color=red> Voy a probar técnicas de relajación como escuchar música tranquila para ayudarme a dormir.",
};

    public string[] Compound26_textsArray = {
    "Let's wash our hands frequently to prevent the spread of germs. \n<color=red> Vamos a lavarnos las manos con frecuencia para prevenir la propagación de gérmenes.",
    "We can get vaccinated to protect ourselves against infectious diseases. \n<color=red> Podemos vacunarnos para protegernos contra enfermedades infecciosas.",
    "She practices good hygiene habits like covering her mouth when coughing. \n<color=red> A ella le gusta practicar buenos hábitos de higiene como cubrirse la boca al toser.",
    "He wants to eat a balanced diet to boost his immune system. \n<color=red> Él quiere comer una dieta balanceada para fortalecer su sistema inmunológico.",
    "I'm going to stay home when I'm sick to avoid spreading illness to others. \n<color=red> Voy a quedarme en casa cuando esté enfermo para evitar propagar la enfermedad a los demás.",
};

    public string[] Compound27_textsArray = {
    "Let's stay active and exercise regularly to maintain our mobility. \n<color=red> Vamos a mantenernos activos y hacer ejercicio regularmente para mantener nuestra movilidad.",
    "We can eat a healthy diet with plenty of nutrients to support aging gracefully. \n<color=red> Podemos comer una dieta saludable con muchos nutrientes para apoyar un envejecimiento grácil.",
    "She enjoys spending time with loved ones to stay mentally and emotionally fulfilled. \n<color=red> A ella le gusta pasar tiempo con sus seres queridos para mantenerse mental y emocionalmente realizada.",
    "He wants to prioritize self-care and relaxation to reduce stress and improve well-being. \n<color=red> Él quiere priorizar el cuidado personal y la relajación para reducir el estrés y mejorar el bienestar.",
    "I'm going to embrace aging as a natural part of life and focus on living fully in the present. \n<color=red> Voy a aceptar el envejecimiento como una parte natural de la vida y enfocarme en vivir plenamente en el presente.",
};

    public string[] Compound28_textsArray = {
    "Let's start with simple exercises like walking or jogging to build stamina. \n<color=red> Comencemos con ejercicios simples como caminar o correr para desarrollar resistencia.",
    "We can gradually increase the intensity of our workouts as we get stronger. \n<color=red> Podemos aumentar gradualmente la intensidad de nuestros entrenamientos a medida que nos volvemos más fuertes.",
    "She enjoys trying new fitness activities like yoga or Pilates to keep workouts fun. \n<color=red> A ella le gusta probar nuevas actividades de fitness como yoga o Pilates para que los entrenamientos sean divertidos.",
    "He wants to set specific fitness goals and track his progress over time. \n<color=red> Él quiere establecer objetivos de fitness específicos y seguir su progreso con el tiempo.",
    "I'm going to find a workout buddy to stay motivated and accountable. \n<color=red> Voy a encontrar un compañero de entrenamiento para mantenerme motivado y responsable.",
};









    public string[] Compound29_textsArray = {
    "Let's learn new things every day and have fun! \n<color=red> ¡Aprendamos cosas nuevas todos los días y divirtámonos!",
    "Reading is fun and helps us learn better. \n<color=red> Leer es divertido y nos ayuda a aprender mejor.",
    "Ask questions when you don't understand and learn more. \n<color=red> Haz preguntas cuando no entiendas y aprende más.",
    "Practice makes perfect! Let's keep practicing. \n<color=red> ¡La práctica hace al maestro! Sigamos practicando.",
    "Education is the key to success. Let's learn and succeed. \n<color=red> La educación es la clave del éxito. Aprendamos y tengamos éxito.",
};

    public string[] Compound30_textsArray = {
    "Study hard to achieve your dreams! Let's reach our goals. \n<color=red> ¡Estudia duro para alcanzar tus sueños! Alcancemos nuestras metas.",
    "Explore different colleges and find your fit. Let's discover what's best for us. \n<color=red> Explora diferentes universidades y encuentra lo que mejor se adapte a ti. Descubramos lo que es mejor para nosotros.",
    "College is a time for growth and discovery. Let's grow and discover. \n<color=red> La universidad es un momento de crecimiento y descubrimiento. Crezcamos y descubramos.",
    "Apply for scholarships to help pay for tuition. Let's get financial aid. \n<color=red> Solicita becas para ayudar a pagar la matrícula. Obtengamos ayuda financiera.",
    "Believe in yourself and your abilities. Let's trust ourselves. \n<color=red> Cree en ti mismo y en tus habilidades. Confíemos en nosotros mismos.",
};

    public string[] Compound31_textsArray = {
    "Visit the library for books and quiet study. Let's read and study. \n<color=red> Visita la biblioteca para libros y estudiar en silencio. Leamos y estudiemos.",
    "Libraries offer resources for research and learning. Let's use library resources. \n<color=red> Las bibliotecas ofrecen recursos para investigación y aprendizaje. Usemos los recursos de la biblioteca.",
    "Reading opens doors to new worlds and ideas. Let's read and explore. \n<color=red> Leer abre puertas a nuevos mundos e ideas. Leamos y exploremos.",
    "Join a book club for discussion and friendship. Let's join and make friends. \n<color=red> Únete a un club de lectura para discusión y amistad. Unámonos y hagamos amigos.",
    "Volunteer at the library to give back to the community. Let's volunteer and help. \n<color=red> Haz trabajo voluntario en la biblioteca para devolver a la comunidad. Voluntariemos y ayudemos.",
};

    public string[] Compound32_textsArray = {
    "Prepare for exams by studying and reviewing. Let's study and review. \n<color=red> Prepárate para los exámenes estudiando y revisando. Estudiemos y repasemos.",
    "Take breaks while studying to stay focused. Let's take breaks and stay focused. \n<color=red> Toma descansos mientras estudias para mantenerte concentrado. Tomemos descansos y mantengámonos concentrados.",
    "Stay calm and confident during exams. Let's stay calm and confident. \n<color=red> Mantén la calma y la confianza durante los exámenes. Mantengámonos tranquilos y seguros.",
    "Study with friends for motivation and support. Let's study together and support each other. \n<color=red> Estudia con amigos para motivación y apoyo. Estudiemos juntos y apoyémonos mutuamente.",
    "Sleep well before exams for a clear mind. Let's sleep well for clarity. \n<color=red> Duerme bien antes de los exámenes para una mente clara. Durmamos bien para tener claridad.",
};

    public string[] Compound33_textsArray = {
    "Participate in class discussions and activities. Let's participate and engage. \n<color=red> Participa en las discusiones y actividades de clase. Participemos y comprometámonos.",
    "Take notes to remember important information. Let's take notes and remember. \n<color=red> Toma notas para recordar la información importante. Tomemos notas y recordemos.",
    "Ask questions when you're unsure. Let's ask and clarify. \n<color=red> Haz preguntas cuando no estés seguro. Preguntemos y aclaremos.",
    "Respect your classmates and their opinions. Let's respect and listen. \n<color=red> Respeta a tus compañeros y sus opiniones. Respetemos y escuchemos.",
    "Stay organized with your schoolwork and assignments. Let's stay organized and focused. \n<color=red> Mantente organizado con tus tareas y deberes escolares. Mantengámonos organizados y concentrados.",
};

    public string[] Compound34_textsArray = {
    "Listen to your professors and learn from their experience. Let's listen and learn. \n<color=red> Escucha a tus profesores y aprende de su experiencia. Escuchemos y aprendamos.",
    "Attend office hours for extra help and guidance. Let's attend and get help. \n<color=red> Asiste a las horas de oficina para ayuda y orientación adicional. Asistamos y obtengamos ayuda.",
    "Ask for feedback to improve your work. Let's ask and improve. \n<color=red> Pide retroalimentación para mejorar tu trabajo. Pidamos y mejoremos.",
    "Be respectful and courteous in class. Let's be respectful and courteous. \n<color=red> Sé respetuoso y cortés en clase. Seamos respetuosos y corteses.",
    "Thank your professors for their dedication and support. Let's thank and appreciate. \n<color=red> Agradece a tus profesores por su dedicación y apoyo. Agradezcamos y apreciemos.",
};

    public string[] Compound35_textsArray = {
    "Explore different topics and research areas. Let's explore and learn. \n<color=red> Explora diferentes temas y áreas de investigación. Exploremos y aprendamos.",
    "Use reliable sources for your research. Let's use reliable sources. \n<color=red> Usa fuentes confiables para tu investigación. Usemos fuentes confiables.",
    "Experiment with new ideas and methods. Let's experiment and innovate. \n<color=red> Experimenta con nuevas ideas y métodos. Experimentemos e innovemos.",
    "Collaborate with peers for diverse perspectives. Let's collaborate and share ideas. \n<color=red> Colabora con tus compañeros para obtener perspectivas diversas. Colaboremos y compartamos ideas.",
    "Share your findings with others to contribute to knowledge. Let's share and contribute. \n<color=red> Comparte tus hallazgos con otros para contribuir al conocimiento. Compartamos y contribuyamos.",
};











    public string[] Compound36_textsArray = {
    "I have a job at the store, and I help customers. \n<color=red> Tengo un trabajo en la tienda, y ayudo a los clientes.",
    "My job is to help customers, and I work five days a week. \n<color=red> Mi trabajo es ayudar a los clientes, y trabajo cinco días a la semana.",
    "I earn money to buy things, and I enjoy my job and my coworkers. \n<color=red> Gano dinero para comprar cosas, y disfruto de mi trabajo y mis compañeros.",
    "Working at the office is enjoyable, and I learn new things every day. \n<color=red> Trabajar en la oficina es agradable, y aprendo cosas nuevas todos los días.",
    "I like my job because it challenges me, and I have opportunities for growth. \n<color=red> Me gusta mi trabajo porque me desafía, y tengo oportunidades de crecimiento.",
};

    public string[] Compound37_textsArray = {
    "Construction workers build houses, and they use tools like hammers and saws. \n<color=red> Los trabajadores de la construcción construyen casas, y usan herramientas como martillos y sierras.",
    "Safety gear is important on the job, and construction sites can be noisy. \n<color=red> El equipo de seguridad es importante en el trabajo, y los sitios de construcción pueden ser ruidosos.",
    "Construction projects take time to complete, and some jobs offer higher wages than others. \n<color=red> Los proyectos de construcción llevan tiempo completarse, y algunos trabajos ofrecen salarios más altos que otros.",
    "Construction workers work in different weather conditions, and teamwork is essential. \n<color=red> Los trabajadores de la construcción trabajan en diferentes condiciones climáticas, y el trabajo en equipo es esencial.",
    "Learning new skills is part of the job, and construction workers take pride in their work. \n<color=red> Aprender nuevas habilidades es parte del trabajo, y los trabajadores de la construcción se enorgullecen de su trabajo.",
};

    public string[] Compound38_textsArray = {
    "I receive my wage every month, and my wage helps me pay for rent and bills. \n<color=red> Recibo mi salario cada mes, y mi salario me ayuda a pagar el alquiler y las facturas.",
    "I work hard to earn my wage, and minimum wage is the lowest amount workers can be paid. \n<color=red> Trabajo duro para ganar mi salario, y el salario mínimo es la cantidad más baja que los trabajadores pueden recibir.",
    "Wages vary depending on the job, and some jobs offer bonuses or overtime pay. \n<color=red> Los salarios varían según el trabajo, y algunos trabajos ofrecen bonificaciones o pago de horas extras.",
    "Earning a good wage allows me to save money for the future, and I budget my expenses carefully. \n<color=red> Ganar un buen salario me permite ahorrar dinero para el futuro, y presupuesto mis gastos cuidadosamente.",
    "Negotiating wages during a job interview is important, and knowing the average wage for the industry is helpful. \n<color=red> Negociar salarios durante una entrevista de trabajo es importante, y conocer el salario promedio para la industria es útil.",
};

    public string[] Compound39_textsArray = {
    "I work in an office building, and I use a computer for my work. \n<color=red> Trabajo en un edificio de oficinas, y uso una computadora para mi trabajo.",
    "My office has a kitchen and a break room, and I have meetings with my coworkers. \n<color=red> Mi oficina tiene una cocina y una sala de descanso, y tengo reuniones con mis compañeros de trabajo.",
    "Working in an office requires good organizational skills, and communication is key. \n<color=red> Trabajar en una oficina requiere buenas habilidades organizativas, y la comunicación es clave.",
    "I have my own desk in the office, and I decorate it with photos and plants. \n<color=red> Tengo mi propio escritorio en la oficina, y lo decoro con fotos y plantas.",
    "Office workers often collaborate on projects, and teamwork is important for success. \n<color=red> Los trabajadores de oficina a menudo colaboran en proyectos, y el trabajo en equipo es importante para el éxito.",
};

    public string[] Compound40_textsArray = {
    "I work in a retail store, and customers come to buy clothes and electronics. \n<color=red> Trabajo en una tienda minorista, y los clientes vienen a comprar ropa y electrónicos.",
    "I help customers find what they need, and retail workers often work on weekends. \n<color=red> Ayudo a los clientes a encontrar lo que necesitan, y los trabajadores minoristas a menudo trabajan los fines de semana.",
    "Working in retail can be fast-paced, and I enjoy interacting with customers. \n<color=red> Trabajar en el comercio minorista puede ser rápido, y disfruto interactuando con los clientes.",
    "Retail workers handle cash transactions, and accuracy is important for balancing the register. \n<color=red> Los trabajadores minoristas manejan transacciones en efectivo, y la precisión es importante para equilibrar el registro.",
    "Retail stores often have sales and promotions, and employees help set up displays. \n<color=red> Las tiendas minoristas a menudo tienen ventas y promociones, y los empleados ayudan a configurar las pantallas.",
};

    public string[] Compound41_textsArray = {
    "I work at the hospital as a nurse, and doctors and nurses help sick people get better. \n<color=red> Trabajo en el hospital como enfermera, y los médicos y enfermeras ayudan a las personas enfermas a mejorar.",
    "The hospital has many departments like emergency and surgery, and patients come to see doctors. \n<color=red> El hospital tiene muchos departamentos como emergencia y cirugía, y los pacientes vienen a ver a los médicos.",
    "Working at the hospital can be challenging, but it's rewarding to make a difference in people's lives. \n<color=red> Trabajar en el hospital puede ser desafiante, pero es gratificante hacer una diferencia en la vida de las personas.",
    "Healthcare workers at the hospital provide compassionate care, and teamwork is essential for patient safety. \n<color=red> Los trabajadores de la salud en el hospital brindan atención compasiva, y el trabajo en equipo es esencial para la seguridad de los pacientes.",
    "Hospital staff work long hours, and they often have to deal with stressful situations. \n<color=red> El personal del hospital trabaja largas horas, y a menudo tienen que lidiar con situaciones estresantes.",
};

    public string[] Compound42_textsArray = {
    "I work at the bank as a teller, and people come to the bank to deposit or withdraw money. \n<color=red> Trabajo en el banco como cajero, y las personas vienen al banco para depositar o retirar dinero.",
    "The bank offers services like loans and savings accounts, and security is important. \n<color=red> El banco ofrece servicios como préstamos y cuentas de ahorro, y la seguridad es importante.",
    "Bank tellers handle financial transactions, and they provide customer service to clients. \n<color=red> Los cajeros del banco manejan transacciones financieras, y brindan servicio al cliente a los clientes.",
    "Working at the bank requires attention to detail, and accuracy is important for handling money. \n<color=red> Trabajar en el banco requiere atención a los detalles, y la precisión es importante para manejar el dinero.",
    "Banks have strict security measures in place, and employees undergo training to prevent fraud. \n<color=red> Los bancos tienen medidas de seguridad estrictas, y los empleados reciben capacitación para prevenir el fraude.",
};



    public string[] Compound43_textsArray = {
    "I love going to the beach with my family, and we swim in the ocean. \n<color=red> Me encanta ir a la playa con mi familia, y nadamos en el océano.",
    "The beach has soft sand, and seagulls fly overhead. \n<color=red> La playa tiene arena suave, y las gaviotas vuelan por encima.",
    "People bring umbrellas and towels to the beach, and children build sandcastles. \n<color=red> Las personas llevan sombrillas y toallas a la playa, y los niños construyen castillos de arena.",
    "The beach is a popular destination for tourists, and there are often beach volleyball tournaments. \n<color=red> La playa es un destino popular para los turistas, y a menudo hay torneos de voleibol playa.",
    "Watching the sunset at the beach is a beautiful experience, and families gather around bonfires. \n<color=red> Ver la puesta de sol en la playa es una experiencia hermosa, y las familias se reúnen alrededor de fogatas.",
};

    public string[] Compound44_textsArray = {
    "I enjoy picnics at the park with my friends, and we play frisbee. \n<color=red> Disfruto de los picnics en el parque con mis amigos, y jugamos frisbee.",
    "The park has tall trees and green grass, and squirrels chase each other. \n<color=red> El parque tiene árboles altos y césped verde, y las ardillas se persiguen.",
    "Families come to the park to relax and have fun, and children ride on the swings. \n<color=red> Las familias vienen al parque para relajarse y divertirse, y los niños montan en los columpios.",
    "The park is a peaceful place to go for a walk, and people walk their dogs. \n<color=red> El parque es un lugar tranquilo para dar un paseo, y la gente pasea a sus perros.",
    "During the summer, the park hosts outdoor concerts, and people bring blankets to sit on. \n<color=red> Durante el verano, el parque alberga conciertos al aire libre, y la gente trae mantas para sentarse.",
};

    public string[] Compound45_textsArray = {
    "I enjoy watching sports games at the stadium with my friends, and we cheer for our favorite teams. \n<color=red> Disfruto viendo juegos deportivos en el estadio con mis amigos, y animamos a nuestros equipos favoritos.",
    "The stadium has a large seating capacity, and there are concession stands selling snacks. \n<color=red> El estadio tiene una gran capacidad de asientos, y hay puestos de comida que venden bocadillos.",
    "Fans come to the stadium wearing team jerseys, and they wave flags and banners. \n<color=red> Los aficionados vienen al estadio vistiendo camisetas de equipo, y ondean banderas y pancartas.",
    "Watching a live game at the stadium is exciting, and the atmosphere is electric. \n<color=red> Ver un juego en vivo en el estadio es emocionante, y el ambiente es eléctrico.",
    "The stadium lights up at night during evening games, and the crowd roars with excitement. \n<color=red> El estadio se ilumina por la noche durante los juegos nocturnos, y la multitud ruge de emoción.",
};

    public string[] Compound46_textsArray = {
    "I enjoy going to parties with my friends, and we dance and have fun. \n<color=red> Disfruto yendo a fiestas con mis amigos, y bailamos y nos divertimos.",
    "Parties have music and decorations, and people dress up in costumes for themed parties. \n<color=red> Las fiestas tienen música y decoraciones, y la gente se disfraza con disfraces para fiestas temáticas.",
    "Guests bring food and drinks to parties, and there are often games and activities. \n<color=red> Los invitados traen comida y bebidas a las fiestas, y a menudo hay juegos y actividades.",
    "Celebrating birthdays and holidays with parties is a tradition, and families gather to celebrate. \n<color=red> Celebrar cumpleaños y fiestas con fiestas es una tradición, y las familias se reúnen para celebrar.",
    "The best part of a party is spending time with friends and making memories together. \n<color=red> La mejor parte de una fiesta es pasar tiempo con amigos y crear recuerdos juntos.",
};

    public string[] Compound47_textsArray = {
    "I enjoy dining out at restaurants with my family, and we try different cuisines. \n<color=red> Disfruto cenando en restaurantes con mi familia, y probamos diferentes cocinas.",
    "Restaurants offer a variety of dishes, and the chefs prepare delicious meals. \n<color=red> Los restaurantes ofrecen una variedad de platos, y los chefs preparan comidas deliciosas.",
    "Diners can choose from appetizers, main courses, and desserts on the menu. \n<color=red> Los comensales pueden elegir entre entrantes, platos principales y postres en el menú.",
    "Eating at a restaurant is a special occasion, and the ambiance adds to the dining experience. \n<color=red> Comer en un restaurante es una ocasión especial, y el ambiente añade a la experiencia gastronómica.",
    "Restaurant staff provide excellent service, and customers leave satisfied with their dining experience. \n<color=red> El personal del restaurante ofrece un excelente servicio, y los clientes salen satisfechos con su experiencia gastronómica.",
};

    public string[] Compound48_textsArray = {
    "I use the internet to stay connected with friends and family, and I enjoy browsing social media. \n<color=red> Uso internet para mantenerme conectado con amigos y familiares, y disfruto navegando en redes sociales.",
    "The internet provides access to information and entertainment, and I watch videos and read articles online. \n<color=red> Internet proporciona acceso a información y entretenimiento, y veo videos y leo artículos en línea.",
    "People use the internet for shopping, banking, and communication, and it has become an essential part of daily life. \n<color=red> Las personas usan internet para comprar, hacer banca y comunicarse, y se ha convertido en una parte esencial de la vida diaria.",
    "Online learning and remote work have become more common with the use of the internet, and it has opened up new opportunities. \n<color=red> El aprendizaje en línea y el trabajo remoto se han vuelto más comunes con el uso de internet, y ha abierto nuevas oportunidades.",
    "Internet safety is important, and people should be cautious when sharing personal information online. \n<color=red> La seguridad en internet es importante, y las personas deben tener cuidado al compartir información personal en línea.",
};

    public string[] Compound49_textsArray = {
    "I enjoy watching movies at the theater with my friends, and we get popcorn and soda. \n<color=red> Disfruto viendo películas en el cine con mis amigos, y compramos palomitas y refrescos.",
    "Movies transport viewers to different worlds and tell captivating stories, and I love the excitement of going to the movies. \n<color=red> Las películas transportan a los espectadores a diferentes mundos y cuentan historias cautivadoras, y me encanta la emoción de ir al cine.",
    "The movie theater has comfortable seats and a big screen, and the sound quality is excellent. \n<color=red> El cine tiene asientos cómodos y una pantalla grande, y la calidad del sonido es excelente.",
    "People enjoy going to the movies for entertainment and relaxation, and it's a popular activity for date nights. \n<color=red> A la gente le gusta ir al cine para entretenerse y relajarse, y es una actividad popular para las citas.",
    "Watching a movie with friends or family is a fun way to spend time together, and it creates lasting memories. \n<color=red> Ver una película con amigos o familiares es una forma divertida de pasar tiempo juntos, y crea recuerdos duraderos.",
};











    /***
     * My house is big, and it has a beautiful garden. - Mi casa es grande, y tiene un jardín hermoso.
I have a dog, and my neighbor has a cat. - Tengo un perro, y mi vecino tiene un gato.
The kitchen is yellow, but the living room is blue. - La cocina es amarilla, pero el salón es azul.
I sleep in my bedroom, and my sister sleeps in hers. - Duermo en mi habitación, y mi hermana duerme en la suya.
The living room has a sofa, and there are two chairs next to it. - El salón tiene un sofá, y hay dos sillas al lado.


    //////

We eat dinner together, and we talk about our day. - Cenamos juntos, y hablamos sobre nuestro día.
My garden has flowers, and I also grow vegetables. - Mi jardín tiene flores, y también cultivo verduras.
I do my homework at the table, and then I watch television. - Hago mis deberes en la mesa, y luego veo la televisión.
The bathroom is clean, and I make sure to keep it that way. - El baño está limpio, y me aseguro de mantenerlo así.
I love my home, and I feel safe and happy here. - Amo mi casa, y me siento seguro y feliz aquí.



    ////////////////

The chair is red, and it matches the curtains. - La silla es roja, y combina con las cortinas.
The table is round, and it can seat four people. - La mesa es redonda, y puede acomodar a cuatro personas.
The bed is big, and it has four pillows. - La cama es grande, y tiene cuatro almohadas.
The lamp is on, and it gives warm light. - La lámpara está encendida, y da una luz cálida.
The sofa is comfortable, and we sit there to watch TV. - El sofá es cómodo, y nos sentamos allí para ver la televisión.


The shelf has books, and there are also picture frames on it. - El estante tiene libros, y también hay marcos de fotos en él.
The desk is new, and I do my homework there. - El escritorio es nuevo, y hago mi tarea allí.
The mirror is clean, and it reflects the sunlight. - El espejo está limpio, y refleja la luz del sol.
The drawer is open, and inside there are socks. - El cajón está abierto, y dentro hay calcetines.
The rug is soft, and the cat loves to sleep on it. - La alfombra es suave, y al gato le encanta dormir en ella.

    ///////////////////////



    The backyard is big, and there is a tree where birds sing. - El patio trasero es grande, y hay un árbol donde los pájaros cantan.
We have flowers in the backyard, and they smell really nice. - Tenemos flores en el patio trasero, y huelen muy bien.
There is a swing in the backyard, and we play on it every day. - Hay un columpio en el patio trasero, y jugamos en él todos los días.
We plant vegetables in the backyard, and we eat them for dinner. - Plantamos verduras en el patio trasero, y las comemos para cenar.
We have a dog in the backyard, and it loves to run around. - Tenemos un perro en el patio trasero, y le encanta correr por ahí.



There is a table and chairs in the backyard, and we have lunch outside. - Hay una mesa y sillas en el patio trasero, y almorzamos afuera.
We have a pool in the backyard, and we swim in it when it's hot. - Tenemos una piscina en el patio trasero, y nadamos en ella cuando hace calor.
There is a barbecue grill in the backyard, and we have parties with our friends. - Hay una parrilla de barbacoa en el patio trasero, y hacemos fiestas con nuestros amigos.
We have a garden in the backyard, and we grow tomatoes and peppers. - Tenemos un jardín en el patio trasero, y cultivamos tomates y pimientos.
There is a hammock in the backyard, and we relax in it on sunny days. - Hay una hamaca en el patio trasero, y nos relajamos en ella en días soleados.

    ////////////////////////

    My mom is kind, and she always helps me with my homework. - Mi mamá es amable, y siempre me ayuda con mi tarea.
My dad is tall, but my uncle is taller. - Mi papá es alto, pero mi tío es más alto.
My sister is funny, and she makes me laugh every day. - Mi hermana es divertida, y me hace reír todos los días.
My brother is smart, and he gets good grades in school. - Mi hermano es inteligente, y saca buenas notas en la escuela.
I love my grandparents, and we visit them on weekends. - Amo a mis abuelos, y los visitamos los fines de semana.
Our family has a dog, and we take him for walks in the park. - Nuestra familia tiene un perro, y lo llevamos a pasear al parque.
My aunt lives far away, but we talk on the phone every week. - Mi tía vive lejos, pero hablamos por teléfono cada semana.
We eat dinner together, and we talk about our day. - Cenamos juntos, y hablamos sobre nuestro día.
My cousin and I play games, and we have a lot of fun together. - Mi primo y yo jugamos juegos, y nos divertimos mucho juntos.
We have family gatherings on holidays, and we celebrate with food and laughter. - Tenemos reuniones familiares en días festivos, y celebramos con comida y risas.


    //////////////////////////////////////////////
    ///

    The light is on, but we need to save electricity. - La luz está encendida, pero necesitamos ahorrar electricidad.
The water is cold, so I'm going to take a warm shower. - El agua está fría, así que voy a tomar una ducha caliente.
The heater is broken, but we have blankets to keep us warm. - La calefacción está rota, pero tenemos mantas para mantenernos calientes.
The air conditioner is loud, but it's too hot to turn it off. - El aire acondicionado hace mucho ruido, pero hace demasiado calor para apagarlo.
The internet is slow, so I can't watch videos online. - El internet está lento, así que no puedo ver videos en línea.
The stove is hot, so be careful when cooking. - La estufa está caliente, así que ten cuidado al cocinar.
The fridge is full, and we need to make room for more groceries. - El refrigerador está lleno, y necesitamos hacer espacio para más compras.
The TV is off, but we can play board games instead. - El televisor está apagado, pero podemos jugar juegos de mesa en su lugar.
The dishwasher is running, so we'll have clean dishes soon. - El lavaplatos está funcionando, así que pronto tendremos platos limpios.
The phone is charging, and I'll be able to use it once it's fully charged. - El teléfono está cargando, y podré usarlo una vez que esté completamente cargado.



    ////////////////
    ///
    The picture is pretty and on the wall. - El cuadro es bonito y está en la pared.
Flowers are in the vase and look fresh. - Hay flores en el jarrón y se ven frescas.
Curtains are white and clean. - Las cortinas son blancas y limpias.
The rug is big and under the table. - La alfombra es grande y está debajo de la mesa.
Pillows are soft and on the bed. - Los cojines son suaves y están en la cama.
The light is on because it's dark. - La luz está encendida porque está oscuro.
The candle smells nice and is new. - La vela huele bien y es nueva.
There is a mirror and it is big. - Hay un espejo y es grande.
The room has colors and looks happy. - La habitación tiene colores y se ve alegre.
We have a lamp and it is bright. - Tenemos una lámpara y es brillante.



    /////////////////
    // Repair/
    The faucet is leaking, so we need to call a plumber. - El grifo está goteando, así que necesitamos llamar a un fontanero.
The door squeaks, but we can fix it with some oil. - La puerta chirría, pero podemos arreglarlo con un poco de aceite.
The window is broken, and we need to replace the glass. - La ventana está rota, y necesitamos reemplazar el vidrio.
The wall needs painting, so we'll buy some paint at the store. - La pared necesita ser pintada, así que compraremos pintura en la tienda.
The floor is dirty, but we'll clean it with a mop. - El suelo está sucio, pero lo limpiaremos con una fregona.
The roof has a leak, and we'll patch it up with some sealant. - El techo tiene una filtración, y lo parchearemos con un sellador.
The toilet is clogged, so we'll use a plunger to unclog it. - El inodoro está atascado, así que usaremos un desatascador para desatascarlo.
The light bulb is burned out, but we have spares in the cupboard. - La bombilla está fundida, pero tenemos repuestos en el armario.
The fence is falling down, and we'll fix it with some nails and a hammer. - La cerca se está cayendo, y la arreglaremos con algunos clavos y un martillo.
The air conditioner doesn't work, so we'll call a technician to repair it. - El aire acondicionado no funciona, así que llamaremos a un técnico para repararlo.


    ////////////////////////////
    ///////////////////////////////
    ///////////////////////
    ///
    I need milk, so I'll go to the grocery store. - Necesito leche, así que iré a la tienda de comestibles.
We are out of bread, but we can buy some at the bakery. - Nos falta pan, pero podemos comprar algo en la panadería.
Do we have eggs? If not, we need to add them to the shopping list. - ¿Tenemos huevos? Si no, necesitamos agregarlos a la lista de compras.
She wants to buy a dress, so she'll visit the clothing store downtown. - Ella quiere comprar un vestido, así que visitará la tienda de ropa del centro.
He is looking for shoes, and he'll check out the shoe store at the mall. - Él está buscando zapatos, y revisará la tienda de zapatos en el centro comercial.
They need new towels, so they'll stop by the department store. - Ellos necesitan toallas nuevas, así que pasarán por la tienda por departamentos.
We are out of shampoo, but we can order some online. - Nos falta champú, pero podemos pedir algo en línea.
She is buying fruits and vegetables, and she'll go to the farmer's market. - Ella está comprando frutas y verduras, y irá al mercado de agricultores.
He is paying with cash, so he'll need to withdraw money from the ATM. - Él está pagando en efectivo, así que necesitará retirar dinero del cajero automático.
They are shopping online because they prefer the convenience. - Ellos están comprando en línea porque prefieren la comodidad.



    //////////////
    
    I like this shirt, but it's too expensive. - Me gusta esta camisa, pero es demasiado cara.
The pants are too long, so I need them hemmed. - Los pantalones están muy largos, así que necesito que los acorten.
She buys a dress and matches it with her shoes. - Ella compra un vestido y lo combina con sus zapatos.
He tries on shoes but can't find his size. - Él se prueba zapatos pero no encuentra su talla.
The jacket is on sale, so I'll buy it now. - La chaqueta está en oferta, así que la compraré ahora.
We look for a tie that matches his suit. - Buscamos una corbata que combine con su traje.
She needs a new scarf to go with her coat. - Ella necesita una bufanda nueva que vaya con su abrigo.
The skirt is blue, which is her favorite color. - La falda es azul, que es su color favorito.
He wants black socks to wear with his formal shoes. - Él quiere calcetines negros para llevar con sus zapatos formales.
They choose sunglasses and a hat for the beach. - Eligen gafas de sol y un sombrero para la playa.

    ///////////////////////////////
    ///
public string[] Rumor1_textsArray = {
    "Build more houses! \n<color=red> Construye más casas.",
    "Not enough houses, please more! \n<color=red> No hay suficientes casas, por favor más.",
    "We need more dog parks! \n<color=red> ¡Necesitamos más parques para perros!",
    "Paint the kitchen blue! \n<color=red> ¡Pinta la cocina de azul!",
    "Decorate your bedroom with flowers! \n<color=red> ¡Decora tu habitación con flores!",
    // Add more phrases as needed
};



     */
    public string[] Rumor1_textsArray = {
    "Build more houses! \n<color=red> Construye más casas.",
    "Not enough houses, please more! \n<color=red> No hay suficientes casas, por favor más.",
    "We need more dog parks! \n<color=red> ¡Necesitamos más parques para perros!",
    "Paint the kitchen blue! \n<color=red> ¡Pinta la cocina de azul!",
    "Decorate your bedroom with flowers! \n<color=red> ¡Decora tu habitación con flores!",
      "Expand the city's housing projects! \n<color=red> ¡Expande los proyectos de vivienda de la ciudad!",
    "There's a shortage of affordable housing! \n<color=red> ¡Hay escasez de viviendas asequibles!",
    "Create more green spaces for pet owners! \n<color=red> ¡Crea más espacios verdes para los dueños de mascotas!",
    "Consider painting the kitchen in vibrant colors! \n<color=red> ¡Considera pintar la cocina con colores vibrantes!",
    "Add a touch of nature to your bedroom decor! \n<color=red> ¡Añade un toque de naturaleza a la decoración de tu habitación!",
    "Revitalize older neighborhoods with new housing developments! \n<color=red> ¡Revitaliza los barrios antiguos con nuevos desarrollos de viviendas!",
    "Encourage community gardening to beautify urban areas! \n<color=red> ¡Fomenta la jardinería comunitaria para embellecer las áreas urbanas!",
    "Promote sustainable architecture for future housing projects! \n<color=red> ¡Promueve la arquitectura sostenible para futuros proyectos de vivienda!",
    "Invest in eco-friendly building materials for construction! \n<color=red> ¡Invierte en materiales de construcción ecológicos para la construcción!",
    "Support initiatives for affordable housing solutions! \n<color=red> ¡Apoya iniciativas para soluciones de vivienda asequibles!",


        "Build eco-friendly homes to reduce carbon footprint! \n<color=red> ¡Construye hogares ecológicos para reducir la huella de carbono!",
    "Create communal living spaces for a sense of community! \n<color=red> ¡Crea espacios de convivencia comunitaria para un sentido de comunidad!",
    "Implement smart home technology for energy efficiency! \n<color=red> ¡Implementa tecnología para el hogar inteligente para la eficiencia energética!",
    "Establish mixed-income housing to promote inclusivity! \n<color=red> ¡Establece viviendas de ingresos mixtos para promover la inclusividad!",
    "Renovate older homes for modern living standards! \n<color=red> ¡Renueva hogares antiguos para estándares de vida modernos!",
    "Encourage urban farming initiatives for sustainable living! \n<color=red> ¡Anima a las iniciativas de agricultura urbana para una vida sostenible!",
    "Provide incentives for green building certifications! \n<color=red> ¡Proporciona incentivos para las certificaciones de construcción ecológica!",
    "Support local artisans for unique home decor options! \n<color=red> ¡Apoya a los artesanos locales para opciones de decoración de hogar únicas!",
    "Integrate affordable housing into urban renewal projects! \n<color=red> ¡Integra viviendas asequibles en proyectos de renovación urbana!",
    "Invest in renewable energy sources for housing developments! \n<color=red> ¡Invierte en fuentes de energía renovable para desarrollos de viviendas!",
  
    // Add more phrases as needed
};

    public string[] Rumor2_textsArray = {
    "Open more stores! \n<color=red> Abre más tiendas.",
    "We need more restaurants! \n<color=red> ¡Necesitamos más restaurantes!",
    "Build a new shopping center! \n<color=red> Construye un nuevo centro comercial.",
    "The city needs a bakery! \n<color=red> ¡La ciudad necesita una panadería!",
    "Let's create a café district! \n<color=red> ¡Creemos un distrito de cafeterías!",
        "Expand the local market for diverse shopping options! \n<color=red> ¡Expande el mercado local para opciones de compra diversas!",
    "Support small businesses with incentives and grants! \n<color=red> ¡Apoya a las pequeñas empresas con incentivos y subvenciones!",
    "Promote food trucks for culinary diversity and convenience! \n<color=red> ¡Promueve los food trucks para diversidad culinaria y conveniencia!",
    "Encourage pop-up shops to showcase local artisans and entrepreneurs! \n<color=red> ¡Anima a las tiendas emergentes para mostrar a los artesanos y emprendedores locales!",
    "Establish a food hall for a vibrant dining scene! \n<color=red> ¡Establece un food hall para una escena gastronómica vibrante!",
    "Introduce street food festivals for culinary experiences! \n<color=red> ¡Introduce festivales de comida callejera para experiencias culinarias!",
    "Invest in public markets for fresh and affordable produce! \n<color=red> ¡Invierte en mercados públicos para productos frescos y asequibles!",
    "Create incentives for unique restaurant concepts and cuisines! \n<color=red> ¡Crea incentivos para conceptos de restaurantes y cocinas únicas!",
    "Support food incubators for culinary entrepreneurship! \n<color=red> ¡Apoya a los incubadoras de alimentos para el emprendimiento culinario!",
    "Implement food waste reduction programs in restaurants! \n<color=red> ¡Implementa programas de reducción de desperdicios de alimentos en restaurantes!",

        "Revitalize the downtown area with new shops and eateries! \n<color=red> ¡Revitaliza el área del centro con nuevas tiendas y restaurantes!",
    "Encourage local artisans to sell their crafts in boutique stores! \n<color=red> ¡Anima a los artesanos locales a vender sus artesanías en tiendas boutique!",
    "Promote farmers' markets to support local growers and producers! \n<color=red> ¡Promueve los mercados de agricultores para apoyar a los agricultores y productores locales!",
    "Develop a culinary trail to highlight unique dining experiences! \n<color=red> ¡Desarrolla una ruta culinaria para resaltar experiencias gastronómicas únicas!",
    "Introduce food tours to showcase the city's culinary diversity! \n<color=red> ¡Introduce tours gastronómicos para mostrar la diversidad culinaria de la ciudad!",
    "Attract renowned chefs to open flagship restaurants in the city! \n<color=red> ¡Atrae a chefs de renombre para abrir restaurantes insignia en la ciudad!",
    "Establish food incubators to support aspiring restaurateurs! \n<color=red> ¡Establece incubadoras de alimentos para apoyar a aspirantes a restauradores!",
    "Host food festivals featuring international cuisines and cultures! \n<color=red> ¡Organiza festivales gastronómicos con cocinas y culturas internacionales!",
    "Create a foodie destination map to guide culinary enthusiasts! \n<color=red> ¡Crea un mapa de destinos gastronómicos para guiar a los entusiastas de la gastronomía!",
    "Promote culinary competitions to showcase local talent! \n<color=red> ¡Promueve competiciones culinarias para mostrar el talento local!",

    // Add more phrases as needed
    // Add more phrases as needed
};

    public string[] Rumor3_textsArray = {
    "We need more hospitals! \n<color=red> ¡Necesitamos más hospitales!",
    "Open a new dental office! \n<color=red> Abre una nueva consulta dental.",
    "The city requires more clinics! \n<color=red> ¡La ciudad necesita más clínicas!",
    "Let's build a medical center! \n<color=red> ¡Construyamos un centro médico!",
    "We should have more pharmacies! \n<color=red> Deberíamos tener más farmacias!",

        "Enhance healthcare accessibility by adding more hospitals! \n<color=red> ¡Mejora la accesibilidad a la atención médica añadiendo más hospitales!",
    "Invest in specialized medical facilities to meet growing healthcare needs! \n<color=red> ¡Invierte en instalaciones médicas especializadas para satisfacer las crecientes necesidades de atención médica!",
    "Expand dental services with new dental offices across the city! \n<color=red> ¡Expande los servicios dentales con nuevas consultas dentales en toda la ciudad!",
    "Establish urgent care centers for prompt medical attention! \n<color=red> ¡Establece centros de atención de urgencia para atención médica rápida!",
    "Provide accessible healthcare options by opening more clinics! \n<color=red> ¡Proporciona opciones de atención médica accesibles abriendo más clínicas!",
    "Introduce telemedicine services to improve healthcare accessibility! \n<color=red> ¡Introduce servicios de telemedicina para mejorar la accesibilidad a la atención médica!",
    "Ensure medication availability by expanding pharmacy services! \n<color=red> ¡Garantiza la disponibilidad de medicamentos mediante la expansión de los servicios de farmacia!",
    "Invest in advanced medical technologies for better patient care! \n<color=red> ¡Invierte en tecnologías médicas avanzadas para una mejor atención al paciente!",
    "Collaborate with healthcare professionals to address community health needs! \n<color=red> ¡Colabora con profesionales de la salud para abordar las necesidades de salud de la comunidad!",
    "Develop a comprehensive healthcare strategy for a healthier city! \n<color=red> ¡Desarrolla una estrategia integral de atención médica para una ciudad más saludable!",

      "Upgrade existing hospitals to meet modern healthcare standards! \n<color=red> ¡Actualiza los hospitales existentes para cumplir con los estándares de atención médica modernos!",
    "Establish specialized medical centers for targeted healthcare services! \n<color=red> ¡Establece centros médicos especializados para servicios de atención médica específicos!",
    "Promote preventive healthcare measures through community health programs! \n<color=red> ¡Promueve medidas de atención médica preventiva a través de programas de salud comunitaria!",
    "Enhance emergency medical response by improving ambulance services! \n<color=red> ¡Mejora la respuesta médica de emergencia mejorando los servicios de ambulancia!",
    "Invest in medical research to find innovative healthcare solutions! \n<color=red> ¡Invierte en investigación médica para encontrar soluciones innovadoras en atención médica!",
    "Provide comprehensive mental health services for a balanced healthcare approach! \n<color=red> ¡Proporciona servicios integrales de salud mental para un enfoque equilibrado de la atención médica!",
    "Ensure equitable healthcare access for all residents regardless of socioeconomic status! \n<color=red> ¡Garantiza el acceso equitativo a la atención médica para todos los residentes, independientemente de su situación socioeconómica!",
    "Improve healthcare infrastructure to support growing population needs! \n<color=red> ¡Mejora la infraestructura de atención médica para satisfacer las crecientes necesidades de la población!",
    "Expand telehealth services to provide medical care remotely! \n<color=red> ¡Expande los servicios de telemedicina para proporcionar atención médica de forma remota!",
    "Foster collaboration between healthcare providers and community organizations for holistic care! \n<color=red> ¡Fomenta la colaboración entre los proveedores de atención médica y las organizaciones comunitarias para una atención integral!",
 
    // Add more phrases as needed
};

    public string[] Rumor4_textsArray = {
    "We need a new university campus! \n<color=red> ¡Necesitamos un nuevo campus universitario!",
    "Let's expand the library! \n<color=red> ¡Expandamos la biblioteca!",
    "The city deserves a science museum! \n<color=red> ¡La ciudad merece un museo de ciencias!",
    "More scholarships for students! \n<color=red> ¡Más becas para los estudiantes!",
    "We should invest in arts education! \n<color=red> ¡Deberíamos invertir en educación artística!",

        "Upgrade university facilities to accommodate more students! \n<color=red> ¡Actualiza las instalaciones universitarias para dar cabida a más estudiantes!",
    "Expand the library's digital resources for greater accessibility! \n<color=red> ¡Amplía los recursos digitales de la biblioteca para una mayor accesibilidad!",
    "Introduce interactive exhibits at the science museum to engage visitors! \n<color=red> ¡Introduce exposiciones interactivas en el museo de ciencias para involucrar a los visitantes!",
    "Establish mentorship programs to support students' academic and career development! \n<color=red> ¡Establece programas de tutoría para apoyar el desarrollo académico y profesional de los estudiantes!",
    "Promote cultural exchange programs to enrich the university experience! \n<color=red> ¡Promueve programas de intercambio cultural para enriquecer la experiencia universitaria!",
    "Invest in research grants to foster innovation and discovery! \n<color=red> ¡Invierte en subvenciones de investigación para fomentar la innovación y el descubrimiento!",
    "Create partnerships with local industries to provide students with practical training opportunities! \n<color=red> ¡Crea asociaciones con industrias locales para proporcionar a los estudiantes oportunidades de formación práctica!",
    "Develop a robust internship program to bridge the gap between academia and industry! \n<color=red> ¡Desarrolla un programa de pasantías sólido para cerrar la brecha entre la academia y la industria!",
    "Establish endowed chairs to attract top-tier faculty members! \n<color=red> ¡Establece cátedras dotadas para atraer a profesores de primer nivel!",
    "Enhance cultural programming at the university to celebrate diversity! \n<color=red> ¡Mejora la programación cultural en la universidad para celebrar la diversidad!",
   "Construct a new state-of-the-art research center on campus! \n<color=red> ¡Construye un nuevo centro de investigación de última generación en el campus!",
    "Renovate existing university buildings to meet modern standards! \n<color=red> ¡Renueva los edificios universitarios existentes para cumplir con los estándares modernos!",
    "Expand the library's collection with diverse literature and resources! \n<color=red> ¡Amplía la colección de la biblioteca con literatura y recursos diversos!",
    "Establish collaborative programs with international universities for global learning opportunities! \n<color=red> ¡Establece programas colaborativos con universidades internacionales para oportunidades de aprendizaje global!",
    "Offer more scholarships and financial aid to support underprivileged students! \n<color=red> ¡Ofrece más becas y ayuda financiera para apoyar a los estudiantes desfavorecidos!",
    "Create interdisciplinary courses to encourage innovation and creativity! \n<color=red> ¡Crea cursos interdisciplinarios para fomentar la innovación y la creatividad!",
    "Upgrade campus infrastructure to enhance accessibility and sustainability! \n<color=red> ¡Mejora la infraestructura del campus para mejorar la accesibilidad y la sostenibilidad!",
    "Implement cutting-edge technology in classrooms to enhance learning experiences! \n<color=red> ¡Implementa tecnología de vanguardia en las aulas para mejorar las experiencias de aprendizaje!",
    "Establish mentorship networks connecting alumni with current students! \n<color=red> ¡Establece redes de tutoría que conecten a exalumnos con estudiantes actuales!",
    "Organize academic conferences and symposiums to showcase research achievements! \n<color=red> ¡Organiza conferencias y simposios académicos para mostrar los logros de investigación!",
 
    // Add more phrases as needed
};

    public string[] Rumor5_textsArray = {
    "We need more office spaces! \n<color=red> ¡Necesitamos más espacios de oficinas!",
    "Let's modernize the office buildings! \n<color=red> ¡Modernicemos los edificios de oficinas!",
    "Invest in sustainable farming practices! \n<color=red> ¡Invierte en prácticas agrícolas sostenibles!",
    "Expand the local farm market! \n<color=red> ¡Expande el mercado local de productos agrícolas!",
    "Support local construction projects! \n<color=red> ¡Apoya proyectos de construcción locales!",

       "Revitalize downtown office districts to attract businesses! \n<color=red> ¡Revitaliza los distritos de oficinas del centro para atraer negocios!",
    "Create coworking spaces for entrepreneurs and startups! \n<color=red> ¡Crea espacios de coworking para emprendedores y startups!",
    "Promote green rooftops on office buildings for environmental sustainability! \n<color=red> ¡Promueve techos verdes en edificios de oficinas para la sostenibilidad ambiental!",
    "Support urban farming initiatives to provide fresh produce to the community! \n<color=red> ¡Apoya iniciativas de agricultura urbana para proporcionar productos frescos a la comunidad!",
    "Invest in infrastructure for renewable energy in office complexes! \n<color=red> ¡Invierte en infraestructura para energía renovable en complejos de oficinas!",
    "Encourage mixed-use development projects to create vibrant office and residential areas! \n<color=red> ¡Anima proyectos de desarrollo de uso mixto para crear áreas de oficinas y residenciales vibrantes!",
    "Implement smart technology solutions to improve office efficiency and sustainability! \n<color=red> ¡Implementa soluciones tecnológicas inteligentes para mejorar la eficiencia y sostenibilidad de las oficinas!",
    "Foster collaboration between local businesses and educational institutions for workforce development! \n<color=red> ¡Fomenta la colaboración entre empresas locales e instituciones educativas para el desarrollo de la fuerza laboral!",
    "Upgrade office infrastructure to accommodate remote work and flexible schedules! \n<color=red> ¡Actualiza la infraestructura de oficinas para adaptarse al trabajo remoto y horarios flexibles!",
    "Promote mixed-use zoning policies to create vibrant, walkable neighborhoods around office districts! \n<color=red> ¡Promueve políticas de zonificación de uso mixto para crear vecindarios vibrantes y transitables alrededor de distritos de oficinas!",

        "Encourage the renovation of historic office buildings to preserve architectural heritage! \n<color=red> ¡Anima la renovación de edificios de oficinas históricos para preservar el patrimonio arquitectónico!",
    "Support initiatives to create affordable office space for small businesses! \n<color=red> ¡Apoya iniciativas para crear espacio de oficina asequible para pequeñas empresas!",
    "Invest in green building certifications for office developments to reduce environmental impact! \n<color=red> ¡Invierte en certificaciones de edificios verdes para desarrollos de oficinas para reducir el impacto ambiental!",
    "Promote alternative transportation options for commuting to and from office districts! \n<color=red> ¡Promueve opciones de transporte alternativas para ir y venir de los distritos de oficinas!",
    "Establish business incubators to support entrepreneurship and innovation in office hubs! \n<color=red> ¡Establece incubadoras de negocios para apoyar el emprendimiento y la innovación en centros de oficinas!",
    "Create incentives for businesses to adopt sustainable practices and reduce carbon footprint! \n<color=red> ¡Crea incentivos para que las empresas adopten prácticas sostenibles y reduzcan la huella de carbono!",
    "Enhance public spaces around office buildings to create inviting and pedestrian-friendly environments! \n<color=red> ¡Mejora los espacios públicos alrededor de edificios de oficinas para crear entornos acogedores y aptos para peatones!",
    "Collaborate with city planners to design office developments that prioritize community needs and urban design principles! \n<color=red> ¡Colabora con urbanistas para diseñar desarrollos de oficinas que prioricen las necesidades de la comunidad y los principios de diseño urbano!",
    "Promote telecommuting options to reduce traffic congestion and improve work-life balance! \n<color=red> ¡Promueve opciones de teletrabajo para reducir la congestión del tráfico y mejorar el equilibrio entre el trabajo y la vida!",
    "Encourage businesses to participate in local economic development initiatives to strengthen the office market! \n<color=red> ¡Anima a las empresas a participar en iniciativas de desarrollo económico local para fortalecer el mercado de oficinas!",
 

    // Add more phrases as needed
};


    public string[] Rumor6_textsArray = {
    "Let's clean up the beaches! \n<color=red> ¡Limpiemos las playas!",
    "Build a new nightclub downtown! \n<color=red> ¡Construyamos una nueva discoteca en el centro!",
    "Upgrade the stadium facilities! \n<color=red> ¡Mejoremos las instalaciones del estadio!",
    "Organize more beach events! \n<color=red> ¡Organicemos más eventos en la playa!",
    "Support local musicians at nightclubs! \n<color=red> ¡Apoyemos a los músicos locales en las discotecas!",
        "Renovate the local museum exhibits! \n<color=red> ¡Renovemos las exhibiciones del museo local!",
    "Organize outdoor concerts in the park! \n<color=red> ¡Organicemos conciertos al aire libre en el parque!",
    "Support local artists with gallery exhibitions! \n<color=red> ¡Apoyemos a los artistas locales con exposiciones en galerías!",
    "Host cultural festivals in the city square! \n<color=red> ¡Organicemos festivales culturales en la plaza de la ciudad!",
    "Bring back movie nights in the community center! \n<color=red> ¡Traigamos de vuelta las noches de cine en el centro comunitario!",
    "Promote street art installations around town! \n<color=red> ¡Promovamos instalaciones de arte callejero en toda la ciudad!",
    "Invite renowned chefs for culinary events! \n<color=red> ¡Invitemos a chefs renombrados para eventos culinarios!",
    "Create a local history museum to preserve heritage! \n<color=red> ¡Creemos un museo de historia local para preservar el patrimonio!",
    "Encourage theater productions at the city theater! \n<color=red> ¡Fomentemos producciones teatrales en el teatro de la ciudad!",
    "Support dance troupes with performance spaces! \n<color=red> ¡Apoyemos a los grupos de danza con espacios para actuaciones!",


        "Expand the city's public art program! \n<color=red> ¡Expandamos el programa de arte público de la ciudad!",
    "Host outdoor film screenings in the park! \n<color=red> ¡Organicemos proyecciones de cine al aire libre en el parque!",
    "Establish a cultural exchange program with neighboring cities! \n<color=red> ¡Establezcamos un programa de intercambio cultural con ciudades vecinas!",
    "Encourage local theaters to stage classic plays! \n<color=red> ¡Animemos a los teatros locales a presentar obras clásicas!",
    "Create an art walk showcasing local talent! \n<color=red> ¡Creemos una caminata artística que muestre el talento local!",
    "Organize music festivals highlighting diverse genres! \n<color=red> ¡Organicemos festivales de música que destaquen géneros diversos!",
    "Support independent bookstores with author events! \n<color=red> ¡Apoyemos a las librerías independientes con eventos de autores!",
    "Promote community storytelling events! \n<color=red> ¡Promovamos eventos comunitarios de narración de historias!",
    "Commission public sculptures to beautify the city! \n<color=red> ¡Encarguemos esculturas públicas para embellecer la ciudad!",
    "Create a cultural district to celebrate diversity! \n<color=red> ¡Creemos un distrito cultural para celebrar la diversidad!",
    "Upgrade playground equipment in city parks! \n<color=red> ¡Actualicemos el equipamiento de los parques infantiles en la ciudad!",
    "Build a new jungle gym in the neighborhood! \n<color=red> ¡Construyamos un nuevo gimnasio de juegos en el vecindario!",
    "Host family movie nights in the community center! \n<color=red> ¡Organicemos noches de cine familiar en el centro comunitario!",
    "Support local theaters with grants for new productions! \n<color=red> ¡Apoyemos a los teatros locales con subvenciones para nuevas producciones!",
    "Create a community theater program for aspiring actors! \n<color=red> ¡Creemos un programa de teatro comunitario para actores aficionados!",
    "Build a state-of-the-art movie theater in the city center! \n<color=red> ¡Construyamos un cine de última generación en el centro de la ciudad!",
    "Organize theater workshops for children during school breaks! \n<color=red> ¡Organicemos talleres de teatro para niños durante las vacaciones escolares!",
    "Install outdoor movie screens in neighborhood parks! \n<color=red> ¡Instalemos pantallas de cine al aire libre en parques del vecindario!",
    "Create a city-wide drama festival to showcase local talent! \n<color=red> ¡Creemos un festival de teatro en toda la ciudad para mostrar el talento local!",
    "Support independent cinemas with screenings of classic films! \n<color=red> ¡Apoyemos a los cines independientes con proyecciones de películas clásicas!",
    // Add more phrases as needed

    // Add more phrases as needed
};


    public string[] Rumor7_textsArray = {
    "Expand the airport runway! \n<color=red> ¡Ampliemos la pista del aeropuerto!",
    "Improve train station accessibility! \n<color=red> ¡Mejoremos la accesibilidad de la estación de tren!",
    "Upgrade the garage security! \n<color=red> ¡Actualicemos la seguridad del garaje!",
    "Introduce more parking spaces at the airport! \n<color=red> ¡Introduzcamos más plazas de aparcamiento en el aeropuerto!",
    "Enhance the train station waiting area! \n<color=red> ¡Mejoremos la zona de espera de la estación de tren!",
    "Install better signage at the airport! \n<color=red> ¡Instalemos una señalización mejor en el aeropuerto!",
    "Provide shuttle services from the train station! \n<color=red> ¡Ofrezcamos servicios de transporte desde la estación de tren!",
    "Implement eco-friendly initiatives in the garage! \n<color=red> ¡Implementemos iniciativas ecológicas en el garaje!",
    "Expand the airport terminal building! \n<color=red> ¡Ampliemos el edificio de la terminal del aeropuerto!",
    "Upgrade the train station platforms! \n<color=red> ¡Actualicemos los andenes de la estación de tren!",
     "Enhance airport security measures! \n<color=red> ¡Mejoremos las medidas de seguridad del aeropuerto!",
    "Modernize train station facilities! \n<color=red> ¡Modernicemos las instalaciones de la estación de tren!",
    "Implement express check-in services at the airport! \n<color=red> ¡Implementemos servicios de check-in express en el aeropuerto!",
    "Upgrade the train station ticketing system! \n<color=red> ¡Actualicemos el sistema de venta de billetes de la estación de tren!",
    "Introduce electric vehicle charging stations at the garage! \n<color=red> ¡Introduzcamos estaciones de carga para vehículos eléctricos en el garaje!",
    "Expand airport parking capacity! \n<color=red> ¡Ampliemos la capacidad de aparcamiento del aeropuerto!",
    "Enhance train station amenities for passengers! \n<color=red> ¡Mejoremos las comodidades de la estación de tren para los pasajeros!",
    "Introduce bike rental services at the airport! \n<color=red> ¡Introduzcamos servicios de alquiler de bicicletas en el aeropuerto!",
    "Upgrade security screening procedures at the airport! \n<color=red> ¡Actualicemos los procedimientos de seguridad en el aeropuerto!",
    "Implement contactless ticketing options at the train station! \n<color=red> ¡Implementemos opciones de venta de billetes sin contacto en la estación de tren!",


      "Construct a new bridge over the river! \n<color=red> ¡Construyamos un nuevo puente sobre el río!",
    "Repair the potholes on Main Street! \n<color=red> ¡Reparemos los baches en la Calle Principal!",
    "Upgrade the traffic signals at busy intersections! \n<color=red> ¡Actualicemos los semáforos en las intersecciones con mucho tráfico!",
    "Install speed bumps on residential streets! \n<color=red> ¡Instalemos topes de velocidad en las calles residenciales!",
    "Expand the highway to ease congestion! \n<color=red> ¡Ampliemos la autopista para aliviar la congestión!",
    "Increase patrols around the neighborhood! \n<color=red> ¡Aumentemos las patrullas en el vecindario!",
    "Improve lighting along pedestrian pathways! \n<color=red> ¡Mejoremos la iluminación a lo largo de los caminos peatonales!",
    "Construct a new police station in the downtown area! \n<color=red> ¡Construyamos una nueva comisaría de policía en el centro de la ciudad!",
    "Implement traffic calming measures on busy roads! \n<color=red> ¡Implementemos medidas de calma del tráfico en las carreteras con mucho tráfico!",
    "Upgrade the infrastructure to withstand severe weather conditions! \n<color=red> ¡Actualicemos la infraestructura para resistir condiciones climáticas severas!",

    // Add more phrases as needed
    // Add more phrases as needed
};
    public string[] InsideChatter1_textsArray = {
    "We love the new furniture in the living room! \n<color=blue> ¡Nos encanta el nuevo mobiliario en la sala de estar!",
    "Do you think we should rearrange the furniture in the dining room? \n<color=blue> ¿Crees que deberíamos reorganizar el mobiliario en el comedor?",
    "He's thinking of painting the walls in the hallway. Any suggestions for colors? \n<color=blue> Él está pensando en pintar las paredes del pasillo. ¿Alguna sugerencia para los colores?",
    "The kitchen looks so spacious now that she's decluttered it. \n<color=blue> La cocina se ve tan espaciosa ahora que ella la ha despejado.",
    "Let's hang some new artwork in the bedroom to liven up the space. \n<color=blue> Coloquemos algunas obras de arte nuevas en el dormitorio para animar el espacio.",
    "I'm thinking of setting up a cozy reading nook in the corner of the living room. \n<color=blue> Estoy pensando en montar un rincón de lectura acogedor en la esquina de la sala de estar.",
    "Did you see the latest episode of our favorite TV show? It was so suspenseful! \n<color=blue> ¿Viste el último episodio de nuestro programa de televisión favorito? ¡Fue tan emocionante!",
    "I'm planning to plant some herbs in the kitchen window. It'll be nice to have fresh herbs for cooking. \n<color=blue> Estoy planeando plantar algunas hierbas en la ventana de la cocina. Será agradable tener hierbas frescas para cocinar.",
    "The new curtains in the bedroom really tie the room together. \n<color=blue> Las nuevas cortinas en el dormitorio realmente unen la habitación.",
    "I'm thinking of trying out a new recipe for dinner tonight. \n<color=blue> Estoy pensando en probar una nueva receta para la cena esta noche.",
    // Add more phrases as needed
};


    public string[] InsideChatter2_textsArray = {
    "We should try the new sushi place downtown. \n<color=blue> Deberíamos probar el nuevo lugar de sushi en el centro.",
    "He's been craving some authentic Italian pizza lately. \n<color=blue> Últimamente ha estado deseando una auténtica pizza italiana.",
    "I love the ambiance of this restaurant, it's so cozy. \n<color=blue> Me encanta el ambiente de este restaurante, es muy acogedor.",
    "Do you think we should order dessert or just call it a night? \n<color=blue> ¿Crees que deberíamos pedir postre o simplemente terminar la cena?",
    "She's thinking of trying out a new recipe for chicken curry tonight. \n<color=blue> Ella está pensando en probar una nueva receta de pollo al curry esta noche.",
    "We're planning to grab some groceries at the store after dinner. \n<color=blue> Estamos planeando comprar algunos comestibles en la tienda después de la cena.",
    "He wants to check out the new electronics store that opened in the mall. \n<color=blue> Quiere echar un vistazo a la nueva tienda de electrónicos que abrió en el centro comercial.",
    "She's considering getting a new dress from the boutique on the second floor. \n<color=blue> Está considerando comprar un vestido nuevo en la boutique del segundo piso.",
    "We're thinking of grabbing a coffee at the café before heading home. \n<color=blue> Estamos pensando en tomar un café en la cafetería antes de volver a casa.",
    "He's planning to browse the bookstore for some new novels to read. \n<color=blue> Está planeando buscar en la librería algunas novelas nuevas para leer.",
    // Add more phrases as needed
};


    public string[] InsideChatter3_textsArray = {
    "I heard they're hiring new nurses for the ER department. \n<color=blue> Escuché que están contratando nuevos enfermeros para el departamento de emergencias.",
    "She's scheduled for a dental checkup next week. \n<color=blue> Tiene programada una revisión dental la próxima semana.",
    "He's getting his blood test results from the medical lab today. \n<color=blue> Hoy va a recibir los resultados de su análisis de sangre del laboratorio médico.",
    "I hope they have some good magazines in the waiting room. \n<color=blue> Espero que tengan algunas revistas interesantes en la sala de espera.",
    "We're visiting grandma in the hospital later today. \n<color=blue> Vamos a visitar a la abuela al hospital más tarde hoy.",
    "She's starting physical therapy sessions next month. \n<color=blue> Ella va a comenzar las sesiones de terapia física el mes que viene.",
    "I need to refill my prescription at the pharmacy. \n<color=blue> Necesito volver a surtir mi receta en la farmacia.",
    "He's going in for a checkup at the doctor's office tomorrow. \n<color=blue> Va a hacerse una revisión en el consultorio del médico mañana.",
    "She's been feeling under the weather lately, might need to see a doctor. \n<color=blue> Últimamente se ha sentido un poco mal, quizás necesite ver a un médico.",
    "We should make sure to wash our hands thoroughly before leaving the lab. \n<color=blue> Deberíamos asegurarnos de lavarnos bien las manos antes de salir del laboratorio.",
    // Add more phrases as needed
};



    public string[] InsideChatter4_textsArray = {
    "He's attending a lecture on quantum physics this afternoon. \n<color=blue> Va a asistir a una conferencia sobre física cuántica esta tarde.",
    "I have a group study session in the library later. \n<color=blue> Tengo una sesión de estudio en grupo en la biblioteca más tarde.",
    "She's researching for her thesis in the university library. \n<color=blue> Está investigando para su tesis en la biblioteca universitaria.",
    "We're signing up for a pottery class at the community college. \n<color=blue> Nos estamos inscribiendo en una clase de cerámica en el colegio comunitario.",
    "He's volunteering at the museum on weekends. \n<color=blue> Está haciendo trabajo voluntario en el museo los fines de semana.",
    "I'm meeting with my advisor to discuss my course schedule. \n<color=blue> Voy a reunirme con mi asesor para discutir mi horario de clases.",
    "She's giving a presentation on ancient civilizations next week. \n<color=blue> Va a hacer una presentación sobre las civilizaciones antiguas la próxima semana.",
    "We're planning a field trip to the natural history museum. \n<color=blue> Estamos planeando una excursión al museo de historia natural.",
    "He's borrowing some books for his research project. \n<color=blue> Va a sacar algunos libros para su proyecto de investigación.",
    "I heard there's a new art exhibit opening at the museum. \n<color=blue> Escuché que hay una nueva exposición de arte que se inaugura en el museo.",
    // Add more phrases as needed
};


    public string[] InsideChatter5_textsArray = {
    "He's working on a new project proposal for the client. \n<color=blue> Está trabajando en una nueva propuesta de proyecto para el cliente.",
    "I have a meeting with the team to discuss the quarterly report. \n<color=blue> Tengo una reunión con el equipo para discutir el informe trimestral.",
    "She's organizing the files for the upcoming audit. \n<color=blue> Está organizando los archivos para la próxima auditoría.",
    "We're brainstorming ideas for the marketing campaign. \n<color=blue> Estamos pensando en ideas para la campaña de marketing.",
    "He's planting new crops in the field today. \n<color=blue> Está plantando nuevos cultivos en el campo hoy.",
    "I'm feeding the animals in the barn right now. \n<color=blue> Estoy alimentando a los animales en el granero ahora mismo.",
    "She's harvesting the crops in the fields. \n<color=blue> Está cosechando los cultivos en los campos.",
    "We're repairing the fence around the pasture. \n<color=blue> Estamos reparando la cerca alrededor del pasto.",
    "He's operating the heavy machinery at the construction site. \n<color=blue> Está operando la maquinaria pesada en el sitio de construcción.",
    "I'm overseeing the construction project progress. \n<color=blue> Estoy supervisando el progreso del proyecto de construcción.",
    // Add more phrases as needed
};


    public string[] InsideChatter6_textsArray = {
    "Let's set up umbrellas and chairs for the beachgoers. \n<color=blue> Vamos a poner sombrillas y sillas para los que van a la playa.",
    "She's renting out surfboards and paddleboards at the beach shack. \n<color=blue> Ella está alquilando tablas de surf y paddleboards en la caseta de la playa.",
    "We're preparing the stage for tonight's concert. \n<color=blue> Estamos preparando el escenario para el concierto de esta noche.",
    "He's sound-checking the microphones for the band. \n<color=blue> Está haciendo una prueba de sonido a los micrófonos para la banda.",
    "I'm selling tickets at the entrance gate. \n<color=blue> Estoy vendiendo boletos en la puerta de entrada.",
    "She's setting up food stalls and beverage stands for the concertgoers. \n<color=blue> Ella está instalando puestos de comida y bebida para los asistentes al concierto.",
    "We're organizing security and crowd control for the stadium event. \n<color=blue> Estamos organizando la seguridad y el control de multitudes para el evento en el estadio.",
    "He's managing the ticket scanning at the stadium entrance. \n<color=blue> Está gestionando el escaneo de boletos en la entrada del estadio.",
    "I'm ushering people to their seats in the stadium. \n<color=blue> Estoy guiando a la gente a sus asientos en el estadio.",
    "She's setting up merchandise booths for the stadium event. \n<color=blue> Ella está instalando puestos de mercancía para el evento en el estadio.",
    // Add more phrases as needed
};


    public string[] InsideChatter7_textsArray = {
    "We're boarding passengers for the flight to Paris. \n<color=blue> Estamos abordando pasajeros para el vuelo a París.",
    "She's checking in luggage at the airport counter. \n<color=blue> Ella está facturando equipaje en el mostrador del aeropuerto.",
    "We're preparing the cabin for takeoff. \n<color=blue> Estamos preparando la cabina para el despegue.",
    "He's conducting safety demonstrations for the passengers. \n<color=blue> Está realizando demostraciones de seguridad para los pasajeros.",
    "I'm serving snacks and beverages to passengers on the flight. \n<color=blue> Estoy sirviendo aperitivos y bebidas a los pasajeros en el vuelo.",
    "She's driving the carpool to work today. \n<color=blue> Ella está conduciendo el coche compartido al trabajo hoy.",
    "We're navigating through heavy traffic on the highway. \n<color=blue> Estamos navegando por un tráfico denso en la autopista.",
    "He's filling up the gas tank at the gas station. \n<color=blue> Está llenando el depósito de gasolina en la gasolinera.",
    "I'm taking the motorcycle for a scenic ride along the coast. \n<color=blue> Estoy llevando la motocicleta a dar un paseo escénico por la costa.",
    "She's cycling to the park for a picnic. \n<color=blue> Ella está yendo en bicicleta al parque para un picnic.",
    // Add more phrases as needed
};























    public string[] HOUSE_textsArray = {
    "The faucet is dripping. \n<color=red> El grifo está goteando.",
    "There's a crack in the ceiling. \n<color=red> Hay una grieta en el techo.",
    "The stairs creak. \n<color=red> Las escaleras crujen.",
    "The doorknob is loose. \n<color=red> El pomo de la puerta está suelto.",
    "The light bulb needs replacing. \n<color=red> La bombilla necesita ser cambiada.",
    "The curtains are torn. \n<color=red> Las cortinas están rotas.",
    "There's a draft coming from the window. \n<color=red> Hay una corriente de aire viniendo de la ventana.",
    "The carpet is stained. \n<color=red> La alfombra está manchada.",
    "The chimney is blocked. \n<color=red> La chimenea está obstruida.",
    "The mirror is cracked. \n<color=red> El espejo está agrietado.",
    "The thermostat is malfunctioning. \n<color=red> El termostato está funcionando mal.",
    "There's a hole in the wall. \n<color=red> Hay un agujero en la pared.",
    "The fence needs repair. \n<color=red> La cerca necesita ser reparada.",
    "The floorboards are squeaky. \n<color=red> Las tablas del suelo crujen.",
    "The attic is infested with pests. \n<color=red> El ático está infestado de plagas.",
               "The paint is peeling off the walls. \n<color=red> La pintura se está descascarando de las paredes.",
    "There's a musty smell in the basement. \n<color=red> Hay un olor a humedad en el sótano.",
    "The doorknob is rusty. \n<color=red> El pomo de la puerta está oxidado.",
    "The floor tiles are cracked. \n<color=red> Las baldosas del suelo están agrietadas.",
    "There are water stains on the ceiling. \n<color=red> Hay manchas de agua en el techo.",
    "The gutter is clogged with leaves. \n<color=red> La canaleta está obstruida con hojas.",
    "The porch railing is loose. \n<color=red> La barandilla del porche está suelta.",
    "The fireplace needs cleaning. \n<color=red> La chimenea necesita limpieza.",
    "There's a broken step on the staircase. \n<color=red> Hay un escalón roto en la escalera.",
    "The doorbell doesn't work. \n<color=red> El timbre no funciona.",
    "The wall sockets are faulty. \n<color=red> Los enchufes de pared están defectuosos.",
    "There's a termite infestation in the attic. \n<color=red> Hay una infestación de termitas en el ático.",
    "The skylight is leaking. \n<color=red> El tragaluz está goteando.",
    "The foundation has cracks. \n<color=red> La base tiene grietas.",
    "There's a wasp nest under the eaves. \n<color=red> Hay un nido de avispas bajo los aleros.",
              "The carpets need vacuuming. \n<color=red> Las alfombras necesitan ser aspiradas.",
    "The fence is falling apart. \n<color=red> La cerca se está desmoronando.",
    "There's a draft coming from the windows. \n<color=red> Hay corrientes de aire provenientes de las ventanas.",
    "The kitchen sink is leaking. \n<color=red> El fregadero de la cocina está goteando.",
    "The light bulbs need replacing. \n<color=red> Las bombillas necesitan ser reemplazadas.",
    "There's a crack in the mirror. \n<color=red> Hay una grieta en el espejo.",
    "The front yard needs mowing. \n<color=red> El patio delantero necesita ser cortado.",
    "The attic insulation is old. \n<color=red> El aislamiento del ático está viejo.",
    "There's a broken sprinkler in the garden. \n<color=red> Hay un aspersor roto en el jardín.",
    "The stairs are creaking. \n<color=red> Las escaleras están crujientes.",
    "The bathroom tiles are stained. \n<color=red> Las baldosas del baño están manchadas.",
    "The air conditioning isn't working. \n<color=red> El aire acondicionado no está funcionando.",
    "There's a moldy smell in the basement. \n<color=red> Hay un olor a moho en el sótano.",
    "The fence needs repainting. \n<color=red> La cerca necesita ser repintada.",
    "The garage door is stuck. \n<color=red> La puerta del garaje está atascada."
};


























    public string[] OFFICE_textsArray = {
    "The printer is always jamming. \n<color=red> La impresora siempre se atasca.",
    "There's too much paperwork to handle. \n<color=red> Hay demasiada documentación para manejar.",
    "The office chairs are uncomfortable. \n<color=red> Las sillas de la oficina son incómodas.",
    "The coffee machine is always broken. \n<color=red> La máquina de café siempre está rota.",
    "The air conditioning is too cold. \n<color=red> El aire acondicionado está demasiado frío.",
    "The Wi-Fi is unreliable. \n<color=red> El Wi-Fi no es confiable.",
    "The office is too noisy. \n<color=red> La oficina es demasiado ruidosa.",
    "The meeting room is always booked. \n<color=red> La sala de reuniones siempre está reservada.",
    "The office kitchen is always messy. \n<color=red> La cocina de la oficina siempre está desordenada.",
    "The deadlines are unrealistic. \n<color=red> Los plazos son poco realistas.",
    "The office is understaffed. \n<color=red> La oficina tiene falta de personal.",
    "The office politics are exhausting. \n<color=red> La política de la oficina es agotadora.",
    "There's too much overtime work. \n<color=red> Hay demasiadas horas extras.",
    "The software we use is outdated. \n<color=red> El software que usamos está obsoleto.",
    "The office doesn't have good coffee. \n<color=red> La oficina no tiene buen café.",
    "There's a lack of communication between departments. \n<color=red> Hay una falta de comunicación entre los departamentos.",
     "The office is always too hot. \n<color=red> La oficina siempre está demasiado caliente.",
    "My desk chair is broken. \n<color=red> Mi silla de escritorio está rota.",
    "There's not enough storage space for documents. \n<color=red> No hay suficiente espacio de almacenamiento para documentos.",
    "The office lights flicker constantly. \n<color=red> Las luces de la oficina parpadean constantemente.",
    "The office bathrooms are not well-maintained. \n<color=red> Los baños de la oficina no están bien mantenidos.",
    "There's a lack of privacy in the open workspace. \n<color=red> Hay falta de privacidad en el espacio de trabajo abierto.",
    "The office chairs are old and uncomfortable. \n<color=red> Las sillas de la oficina son viejas e incómodas.",
    "There's a lot of gossip and rumors going around. \n<color=red> Hay muchos chismes y rumores circulando.",
    "The office equipment is outdated and slow. \n<color=red> El equipo de oficina está obsoleto y lento.",
    "There are constant interruptions during work hours. \n<color=red> Hay constantes interrupciones durante las horas de trabajo.",
    "The office layout is inefficient. \n<color=red> La disposición de la oficina es ineficiente.",
    "There's too much emphasis on meetings rather than actual work. \n<color=red> Se hace demasiado hincapié en las reuniones en lugar del trabajo real.",
    "The office policies are too strict. \n<color=red> Las políticas de la oficina son demasiado estrictas.",
    "There's a lack of recognition for hard work. \n<color=red> Hay una falta de reconocimiento por el trabajo duro.",
    "The office is too cluttered and disorganized. \n<color=red> La oficina está demasiado desordenada y desorganizada.",
    "The office is located too far from public transportation. \n<color=red> La oficina está ubicada demasiado lejos del transporte público."

};









    public string[] FARM_textsArray = {
    "The barn roof is leaking. \n<color=red> El techo del granero tiene una filtración.",
    "There's a shortage of feed for the livestock. \n<color=red> Hay escasez de alimento para el ganado.",
    "The tractor is out of fuel again. \n<color=red> El tractor se quedó sin combustible de nuevo.",
    "We need to repair the fence around the pasture. \n<color=red> Necesitamos reparar la cerca alrededor del pasto.",
    "There's an infestation of pests in the crops. \n<color=red> Hay una infestación de plagas en los cultivos.",
    "The irrigation system needs maintenance. \n<color=red> El sistema de riego necesita mantenimiento.",
    "We're running low on fertilizer for the fields. \n<color=red> Nos estamos quedando sin fertilizante para los campos.",
    "The hay storage is overflowing. \n<color=red> El almacenamiento de heno está desbordado.",
    "There's a broken gate near the chicken coop. \n<color=red> Hay una puerta rota cerca del gallinero.",
    "We need to mend the roof of the farmhouse. \n<color=red> Necesitamos reparar el techo de la casa de campo.",
    "The well pump is malfunctioning. \n<color=red> La bomba del pozo no funciona correctamente.",
    "There's a problem with the milking equipment. \n<color=red> Hay un problema con el equipo de ordeño.",
    "We need more hands for harvesting season. \n<color=red> Necesitamos más manos para la temporada de cosecha.",
    "The sheep are getting into the vegetable garden again. \n<color=red> Las ovejas están entrando en el huerto de verduras de nuevo.",
    "The windmill needs repair to generate electricity. \n<color=red> El molino de viento necesita reparación para generar electricidad.",
                "The chicken coop needs cleaning. \n<color=red> El gallinero necesita limpieza.",
    "We're running low on water for irrigation. \n<color=red> Nos estamos quedando sin agua para el riego.",
    "The cows broke through the fence and got into the garden. \n<color=red> Las vacas rompieron la cerca y entraron en el jardín.",
    "There's a problem with the hay baler. \n<color=red> Hay un problema con la empacadora de heno.",
    "The crops are wilting due to lack of water. \n<color=red> Los cultivos se están marchitando debido a la falta de agua.",
    "We need to repair the chicken wire around the coop. \n<color=red> Necesitamos reparar el alambre de pollo alrededor del gallinero.",
    "The goats are escaping through the gaps in the fence. \n<color=red> Las cabras están escapando por los huecos en la cerca.",
    "There's a problem with the irrigation pump. \n<color=red> Hay un problema con la bomba de riego.",
    "The silo is nearly full, we need to start selling grain. \n<color=red> El silo está casi lleno, necesitamos empezar a vender grano.",
    "The sheep are due for shearing. \n<color=red> Las ovejas deben ser esquiladas.",
    "We need to plow the fields before planting season. \n<color=red> Necesitamos arar los campos antes de la temporada de siembra.",
    "The hens aren't laying enough eggs. \n<color=red> Las gallinas no están poniendo suficientes huevos.",
    "The orchard needs pruning to improve fruit yield. \n<color=red> El huerto necesita poda para mejorar el rendimiento de frutas.",
    "The horses need to be shod. \n<color=red> Los caballos necesitan ser herrados.",
    "The vegetable patch needs weeding. \n<color=red> El huerto de verduras necesita ser desmalezado."

};



    public string[] CONSTRUCTION_textsArray = {
    "We're behind schedule on pouring the foundation. \n<color=red> Estamos atrasados en verter la base.",
    "The crane broke down, causing delays. \n<color=red> La grúa se averió, causando retrasos.",
    "We're running low on cement. \n<color=red> Estamos quedándonos sin cemento.",
    "The scaffolding needs to be inspected for safety. \n<color=red> Se necesita inspeccionar los andamios para la seguridad.",
    "There's a problem with the electrical wiring. \n<color=red> Hay un problema con el cableado eléctrico.",
    "The roof trusses are being installed today. \n<color=red> Se están instalando las cerchas del techo hoy.",
    "We need more workers to speed up construction. \n<color=red> Necesitamos más trabajadores para acelerar la construcción.",
    "The concrete mixer needs repairs. \n<color=red> La mezcladora de concreto necesita reparaciones.",
    "The plumbing system is leaking. \n<color=red> El sistema de fontanería está goteando.",
    "The building permits haven't been approved yet. \n<color=red> Las licencias de construcción aún no han sido aprobadas.",
    "The excavator hit a water pipe, causing a flood. \n<color=red> La excavadora golpeó una tubería de agua, causando una inundación.",
    "We're waiting for delivery of steel beams for the framework. \n<color=red> Estamos esperando la entrega de vigas de acero para el armazón.",
    "The construction site needs better security measures. \n<color=red> El sitio de construcción necesita mejores medidas de seguridad.",
    "We're dealing with soil erosion on the site. \n<color=red> Estamos lidiando con la erosión del suelo en el sitio.",
    "The concrete foundation needs to cure for another day. \n<color=red> La base de concreto necesita curarse por otro día.",
      "We're facing delays due to inclement weather. \n<color=red> Estamos enfrentando retrasos debido al mal tiempo.",
    "The demolition work is complete, now onto excavation. \n<color=red> El trabajo de demolición está completo, ahora pasamos a la excavación.",
    "We need to reinforce the scaffolding for additional support. \n<color=red> Necesitamos reforzar los andamios para mayor soporte.",
    "The concrete foundation has cracked and needs repair. \n<color=red> La base de concreto se ha agrietado y necesita reparación.",
    "We're installing new safety barriers around the perimeter. \n<color=red> Estamos instalando nuevas barreras de seguridad alrededor del perímetro.",
    "The construction crew is working overtime to meet deadlines. \n<color=red> El equipo de construcción está trabajando horas extras para cumplir con los plazos.",
    "The project budget has exceeded expectations, and we need to revise our estimates. \n<color=red> El presupuesto del proyecto ha superado las expectativas, y necesitamos revisar nuestros cálculos.",
    "We're coordinating with subcontractors for plumbing and electrical work. \n<color=red> Estamos coordinando con subcontratistas para trabajos de fontanería y eléctricos.",
    "The concrete forms are being set up for pouring tomorrow. \n<color=red> Los moldes de concreto se están preparando para verter mañana.",
    "We've encountered unexpected bedrock while excavating. \n<color=red> Nos encontramos con lecho rocoso inesperado durante la excavación.",
    "The building inspector will be visiting the site next week. \n<color=red> El inspector de edificios visitará el sitio la próxima semana.",
    "We're installing energy-efficient windows to improve insulation. \n<color=red> Estamos instalando ventanas eficientes en energía para mejorar el aislamiento.",
    "The project manager is reviewing the construction schedule for any adjustments. \n<color=red> El gerente de proyecto está revisando el cronograma de construcción para cualquier ajuste.",
    "We're hiring additional laborers for the landscaping phase. \n<color=red> Estamos contratando trabajadores adicionales para la fase de paisajismo.",
    "The crane operator needs to undergo safety training before resuming work. \n<color=red> El operador de grúa necesita recibir capacitación en seguridad antes de reanudar el trabajo."

};


    public string[] RESTAURANT_textsArray = {
    "We're running low on ingredients for the specials tonight. \n<color=red> Nos estamos quedando sin ingredientes para los especiales de esta noche.",
    "The dishwasher is acting up again, and we're falling behind on dishes. \n<color=red> El lavavajillas está fallando de nuevo, y nos estamos quedando atrás con los platos.",
    "We need to restock the bar with more wine and spirits. \n<color=red> Necesitamos reponer la barra con más vino y licores.",
    "The kitchen staff is overwhelmed with orders during peak hours. \n<color=red> El personal de cocina está abrumado con pedidos durante las horas pico.",
    "The air conditioning in the dining area isn't working, and customers are complaining. \n<color=red> El aire acondicionado en el área de comedor no funciona y los clientes se están quejando.",
    "We're short-staffed for the weekend brunch rush. \n<color=red> Tenemos poco personal para el ajetreo del brunch de fin de semana.",
    "The delivery of fresh produce didn't arrive on time, and now we're scrambling to find alternatives. \n<color=red> La entrega de productos frescos no llegó a tiempo, y ahora estamos buscando alternativas.",
    "One of the waitstaff called in sick, and we need someone to cover their shift. \n<color=red> Uno de los camareros se ha enfermado, y necesitamos a alguien que cubra su turno.",
    "The chef accidentally burnt a batch of appetizers, and we're behind schedule for orders. \n<color=red> El chef quemó accidentalmente un lote de aperitivos, y estamos retrasados en los pedidos.",
    "We've received complaints about the noise level in the dining area, and we need to address it. \n<color=red> Hemos recibido quejas sobre el nivel de ruido en el área de comedor, y necesitamos abordarlo.",
    "The POS system crashed, and we're manually taking orders until it's fixed. \n<color=red> El sistema de punto de venta se bloqueó, y estamos tomando pedidos manualmente hasta que se solucione.",
    "The health inspector is due for a surprise visit today, so everyone needs to be on their best behavior. \n<color=red> El inspector de salud tiene programada una visita sorpresa hoy, así que todos deben comportarse bien.",
    "We're introducing a new menu item, and the kitchen staff needs to be trained on how to prepare it. \n<color=red> Estamos introduciendo un nuevo plato en el menú, y el personal de cocina necesita ser capacitado en cómo prepararlo.",
    "The front-of-house staff needs to upsell desserts to increase revenue. \n<color=red> El personal de la parte delantera necesita promocionar los postres para aumentar los ingresos.",
    "We need to organize a staff meeting to discuss service improvements and address any concerns. \n<color=red> Necesitamos organizar una reunión de personal para discutir mejoras en el servicio y abordar cualquier inquietud.",
     "The ice machine is malfunctioning, and we're running out of ice for drinks. \n<color=red> La máquina de hielo está fallando, y nos estamos quedando sin hielo para las bebidas.",
    "We've received complaints about slow service, and we need to pick up the pace. \n<color=red> Hemos recibido quejas sobre el servicio lento, y necesitamos acelerar el ritmo.",
    "There's a mix-up with the reservations, and we need to find seating for extra guests. \n<color=red> Hay un error con las reservas, y necesitamos encontrar asientos para huéspedes adicionales.",
    "The kitchen is backed up, and customers are waiting too long for their food. \n<color=red> La cocina está congestionada, y los clientes están esperando demasiado tiempo por su comida.",
    "We're out of some key ingredients, and we need to update the menu accordingly. \n<color=red> Nos quedamos sin algunos ingredientes clave, y necesitamos actualizar el menú en consecuencia.",
    "The dining area needs a thorough cleaning before the evening rush. \n<color=red> El área de comedor necesita una limpieza a fondo antes del ajetreo nocturno.",
    "There's a leak in the plumbing, and we need to shut off the water until it's fixed. \n<color=red> Hay una fuga en la fontanería, y necesitamos cerrar el agua hasta que se repare.",
    "We're introducing a new chef's special, and the staff needs to be briefed on the ingredients and preparation. \n<color=red> Estamos introduciendo un nuevo plato especial del chef, y el personal necesita ser informado sobre los ingredientes y la preparación.",
    "We're short on clean tableware, and we need to run a load through the dishwasher immediately. \n<color=red> Tenemos poco menaje limpio, y necesitamos poner un lavado en el lavavajillas inmediatamente.",
    "The lighting in the dining area is too dim, and we need to replace the bulbs for better ambiance. \n<color=red> La iluminación en el área de comedor es demasiado tenue, y necesitamos reemplazar las bombillas para crear mejor ambiente.",
    "We're receiving a large party reservation tonight, and we need extra staff to accommodate them. \n<color=red> Estamos recibiendo una reserva de un grupo grande esta noche, y necesitamos personal adicional para atenderlos.",
    "The outdoor seating area needs to be cleaned and set up for guests. \n<color=red> El área de asientos al aire libre necesita ser limpiada y preparada para los huéspedes.",
    "We need to update the menu boards with today's specials and promotions. \n<color=red> Necesitamos actualizar los carteles del menú con los especiales y promociones del día.",
    "There's a discrepancy in the cash register, and we need to reconcile the sales. \n<color=red> Hay una discrepancia en la caja registradora, y necesitamos conciliar las ventas.",
    "The air conditioning is malfunctioning, and we need to provide fans for customer comfort. \n<color=red> El aire acondicionado está fallando, y necesitamos proporcionar ventiladores para la comodidad de los clientes."

};

    public string[] HOSPITAL_textsArray = {
    "We're running low on bandages in the supply room. \n<color=red>Estamos bajos de vendajes en la sala de suministros.",
    "The patient in room 302 needs a new IV drip. \n<color=red>El paciente en la habitación 302 necesita un nuevo goteo intravenoso.",
    "The waiting area is getting crowded. We need more chairs. \n<color=red>El área de espera se está llenando. Necesitamos más sillas.",
    "The lab results for Mr. Smith are ready for review. \n<color=red>Los resultados del laboratorio para el Sr. Smith están listos para su revisión.",
    "We're out of gloves in the examination rooms. \n<color=red>Nos quedamos sin guantes en las salas de examen.",
    "The elevator in the east wing is out of service again. \n<color=red>El ascensor en el ala este está fuera de servicio nuevamente.",
    "Dr. Johnson's surgery has been rescheduled to 2 PM. \n<color=red>La cirugía del Dr. Johnson ha sido reprogramada para las 2 PM.",
    "We need to order more flu vaccines for the upcoming season. \n<color=red>Necesitamos pedir más vacunas contra la gripe para la próxima temporada.",
    "The pharmacy is closed for inventory until noon. \n<color=red>La farmacia está cerrada por inventario hasta el mediodía.",
    "The MRI machine is experiencing technical difficulties. \n<color=red>La máquina de resonancia magnética está experimentando dificultades técnicas.",
    "Please ensure all medical charts are properly updated. \n<color=red>Por favor, asegúrese de que todas las fichas médicas estén debidamente actualizadas.",
    "We're short-staffed in the pediatric ward today. \n<color=red>Hoy tenemos poco personal en la sala pediátrica.",
    "The cafeteria is serving lunch until 2 PM. \n<color=red>La cafetería está sirviendo almuerzo hasta las 2 PM.",
    "The janitorial staff is cleaning the ER waiting room. \n<color=red>El personal de limpieza está limpiando la sala de espera de urgencias.",
    "The parking lot is full. Patients may need to park off-site. \n<color=red>El estacionamiento está lleno. Los pacientes pueden necesitar estacionarse fuera del lugar.",
    "We're conducting a fire drill at 10 AM tomorrow. \n<color=red>Estamos llevando a cabo un simulacro de incendio mañana a las 10 AM.",
    "Please label all specimens clearly before sending them to the lab. \n<color=red>Por favor, etiquete todas las muestras claramente antes de enviarlas al laboratorio.",
       "The surgical team is prepping for an emergency procedure. \n<color=red>El equipo quirúrgico se está preparando para un procedimiento de emergencia.",
    "The ultrasound technician is running behind schedule. \n<color=red>El técnico de ultrasonido se está retrasando en el horario.",
    "We're experiencing a high volume of calls at the reception desk. \n<color=red>Estamos experimentando un alto volumen de llamadas en la recepción.",
    "The X-ray machine in Radiology Room 1 is malfunctioning. \n<color=red>La máquina de rayos X en la Sala de Radiología 1 está funcionando mal.",
    "The patient in Room 205 needs assistance getting to the bathroom. \n<color=red>El paciente en la habitación 205 necesita ayuda para ir al baño.",
    "The ICU is at full capacity. We're coordinating transfers to other facilities. \n<color=red>La UCI está al máximo de su capacidad. Estamos coordinando traslados a otras instalaciones.",
    "We're expecting a delivery of medical supplies at 2 PM. \n<color=red>Esperamos una entrega de suministros médicos a las 2 PM.",
    "The cafeteria menu for the week is now available. \n<color=red>El menú de la cafetería para la semana ya está disponible.",
    "The medical records department is closed for staff training until 1 PM. \n<color=red>El departamento de registros médicos está cerrado por entrenamiento del personal hasta la 1 PM.",
    "The patient transport service is running smoothly. \n<color=red>El servicio de transporte de pacientes está funcionando sin problemas.",
    "The oxygen tanks in the ER need to be refilled. \n<color=red>Los tanques de oxígeno en la sala de emergencias necesitan ser rellenados.",
    "We're conducting a blood drive next week. Sign up to donate! \n<color=red>Estamos llevando a cabo una campaña de donación de sangre la próxima semana. ¡Inscríbete para donar!",
    "The hospital's annual health fair will be held on Saturday. \n<color=red>La feria de salud anual del hospital se llevará a cabo el sábado.",
    "The neonatal intensive care unit is restricting visitors due to a flu outbreak. \n<color=red>La unidad de cuidados intensivos neonatales está restringiendo visitas debido a un brote de gripe.",
    "All medical staff are reminded to wash their hands frequently to prevent infections. \n<color=red>Se recuerda a todo el personal médico lavarse las manos con frecuencia para prevenir infecciones.",
    "The hospital administration office will be closed for the holiday weekend. \n<color=red>La oficina de administración del hospital estará cerrada durante el fin de semana festivo.",
    "The emergency department is currently treating a trauma patient. \n<color=red>El departamento de emergencias está tratando actualmente a un paciente con trauma."

};





    public string[] TEACHING_textsArray = {
    "The students are working on a group project in the classroom. \n<color=red>Los estudiantes están trabajando en un proyecto grupal en el salón de clases.",
    "The teacher is explaining a new concept using visual aids. \n<color=red>El profesor está explicando un nuevo concepto utilizando materiales visuales.",
    "The school is organizing a field trip to the local museum next week. \n<color=red>La escuela está organizando una excursión al museo local la próxima semana.",
    "The students are participating in a lively debate about environmental issues. \n<color=red>Los estudiantes están participando en un animado debate sobre temas ambientales.",
    "The principal is conducting classroom observations to provide feedback to teachers. \n<color=red>El director está realizando observaciones en el aula para brindar retroalimentación a los maestros.",
    "The school is implementing a new curriculum to align with state standards. \n<color=red>La escuela está implementando un nuevo plan de estudios para alinearse con los estándares estatales.",
    "The teachers are attending a professional development workshop on student assessment. \n<color=red>Los profesores están asistiendo a un taller de desarrollo profesional sobre evaluación estudiantil.",
    "The school library is hosting a book fair to promote reading among students. \n<color=red>La biblioteca escolar está organizando una feria del libro para promover la lectura entre los estudiantes.",
    "The math teacher is using interactive games to teach fractions to her students. \n<color=red>La profesora de matemáticas está utilizando juegos interactivos para enseñar fracciones a sus estudiantes.",
    "The school is implementing new technology in the classroom to enhance learning. \n<color=red>La escuela está implementando nueva tecnología en el aula para mejorar el aprendizaje.",
    "The teachers are collaborating to create interdisciplinary projects for students. \n<color=red>Los profesores están colaborando para crear proyectos interdisciplinarios para los estudiantes.",
    "The school counselor is meeting with students to provide academic and emotional support. \n<color=red>El consejero escolar está reuniéndose con los estudiantes para brindar apoyo académico y emocional.",
    "The school is celebrating Teacher Appreciation Week with special events and activities. \n<color=red>La escuela está celebrando la Semana de Agradecimiento al Maestro con eventos y actividades especiales.",
    "The art teacher is showcasing student artwork in the school gallery. \n<color=red>El profesor de arte está exhibiendo obras de arte de los estudiantes en la galería escolar.",
    "The teachers are collaborating with parents to support student learning at home. \n<color=red>Los profesores están colaborando con los padres para apoyar el aprendizaje de los estudiantes en casa.",
    "The school is hosting a science fair to showcase student research projects. \n<color=red>La escuela está organizando una feria de ciencias para mostrar los proyectos de investigación de los estudiantes.",
     "The English teacher is leading a discussion on classic literature. \n<color=red>La profesora de inglés está liderando una discusión sobre literatura clásica.",
    "The students are practicing their multiplication tables during math class. \n<color=red>Los estudiantes están practicando sus tablas de multiplicar durante la clase de matemáticas.",
    "The history teacher is using primary sources to teach about World War II. \n<color=red>El profesor de historia está utilizando fuentes primarias para enseñar sobre la Segunda Guerra Mundial.",
    "The school is hosting a parent-teacher conference to discuss student progress. \n<color=red>La escuela está organizando una conferencia de padres y maestros para discutir el progreso de los estudiantes.",
    "The science teacher is conducting a hands-on experiment to demonstrate chemical reactions. \n<color=red>El profesor de ciencias está llevando a cabo un experimento práctico para demostrar reacciones químicas.",
    "The students are giving presentations on famous inventors for Inventors' Day. \n<color=red>Los estudiantes están dando presentaciones sobre inventores famosos para el Día de los Inventores.",
    "The physical education teacher is leading a class in yoga and mindfulness. \n<color=red>El profesor de educación física está dirigiendo una clase de yoga y atención plena.",
    "The school is hosting a career day to expose students to various professions. \n<color=red>La escuela está organizando un día de carrera para exponer a los estudiantes a diversas profesiones.",
    "The music teacher is rehearsing with the school choir for an upcoming concert. \n<color=red>El profesor de música está ensayando con el coro escolar para un próximo concierto.",
    "The students are participating in a debate on current events in social studies class. \n<color=red>Los estudiantes están participando en un debate sobre eventos actuales en la clase de estudios sociales.",
    "The foreign language teacher is introducing students to cultural customs and traditions. \n<color=red>El profesor de idiomas está introduciendo a los estudiantes en costumbres y tradiciones culturales.",
    "The school is implementing a mentoring program to support new teachers. \n<color=red>La escuela está implementando un programa de tutoría para apoyar a los nuevos maestros.",
    "The drama teacher is directing a school production of Shakespeare's Romeo and Juliet. \n<color=red>El profesor de teatro está dirigiendo una producción escolar de Romeo y Julieta de Shakespeare.",
    "The students are working on a community service project to give back to their local community. \n<color=red>Los estudiantes están trabajando en un proyecto de servicio comunitario para devolver a su comunidad local.",
    "The school counselor is conducting individual sessions with students to address their academic and personal needs. \n<color=red>El consejero escolar está llevando a cabo sesiones individuales con estudiantes para abordar sus necesidades académicas y personales.",
    "The teachers are collaborating with the school librarian to promote literacy initiatives. \n<color=red>Los profesores están colaborando con el bibliotecario escolar para promover iniciativas de alfabetización."

};

    public string[] MARKETING_textsArray = {
    "The sales team is conducting cold calls to generate leads for the new product launch. \n<color=red>El equipo de ventas está realizando llamadas en frío para generar oportunidades para el lanzamiento del nuevo producto.",
    "The marketing manager is analyzing market trends to develop a strategic advertising campaign. \n<color=red>El gerente de marketing está analizando las tendencias del mercado para desarrollar una campaña publicitaria estratégica.",
    "The sales representative is pitching the company's services to potential clients during a meeting. \n<color=red>El representante de ventas está presentando los servicios de la empresa a clientes potenciales durante una reunión.",
    "The marketing team is brainstorming ideas for a social media promotion to increase brand awareness. \n<color=red>El equipo de marketing está generando ideas para una promoción en redes sociales para aumentar el conocimiento de la marca.",
    "The sales manager is setting sales targets and quotas for the upcoming quarter. \n<color=red>El gerente de ventas está estableciendo objetivos de ventas y cuotas para el próximo trimestre.",
    "The marketing coordinator is coordinating the logistics for an upcoming trade show. \n<color=red>El coordinador de marketing está coordinando la logística para una próxima feria comercial.",
    "The sales team is following up with leads from a recent email marketing campaign. \n<color=red>El equipo de ventas está haciendo seguimiento a oportunidades generadas por una reciente campaña de marketing por correo electrónico.",
    "The marketing director is analyzing the performance of various advertising channels to optimize the marketing budget. \n<color=red>El director de marketing está analizando el rendimiento de diversos canales de publicidad para optimizar el presupuesto de marketing.",
    "The sales executive is negotiating terms with a potential client to close a deal. \n<color=red>El ejecutivo de ventas está negociando los términos con un cliente potencial para cerrar un trato.",
    "The marketing specialist is conducting market research to identify new target demographics. \n<color=red>El especialista en marketing está realizando investigaciones de mercado para identificar nuevos segmentos de mercado objetivo.",
    "The sales team is participating in a sales training workshop to improve their closing techniques. \n<color=red>El equipo de ventas está participando en un taller de capacitación en ventas para mejorar sus técnicas de cierre.",
    "The marketing coordinator is coordinating the production of marketing materials for an upcoming product launch. \n<color=red>El coordinador de marketing está coordinando la producción de materiales de marketing para el próximo lanzamiento de un producto.",
    "The sales representative is conducting product demonstrations for potential clients at a trade show. \n<color=red>El representante de ventas está realizando demostraciones de productos para clientes potenciales en una feria comercial.",
    "The marketing team is collaborating with the design team to create visually appealing promotional materials. \n<color=red>El equipo de marketing está colaborando con el equipo de diseño para crear materiales promocionales visualmente atractivos.",
    "The sales manager is analyzing sales data to identify trends and opportunities for growth. \n<color=red>El gerente de ventas está analizando datos de ventas para identificar tendencias y oportunidades de crecimiento.",
    "The marketing coordinator is coordinating the launch event for the company's new product line. \n<color=red>El coordinador de marketing está coordinando el evento de lanzamiento para la nueva línea de productos de la empresa.",
     "The sales team is conducting market research to identify potential clients. \n<color=red>El equipo de ventas está realizando investigaciones de mercado para identificar clientes potenciales.",
    "The marketing manager is analyzing competitor strategies to develop a competitive advantage. \n<color=red>El gerente de marketing está analizando las estrategias de los competidores para desarrollar una ventaja competitiva.",
    "The sales representative is preparing presentations for client meetings. \n<color=red>El representante de ventas está preparando presentaciones para reuniones con clientes.",
    "The marketing team is launching a digital advertising campaign targeting millennial consumers. \n<color=red>El equipo de marketing está lanzando una campaña publicitaria digital dirigida a consumidores millennials.",
    "The sales manager is coaching the sales team on effective negotiation techniques. \n<color=red>El gerente de ventas está capacitando al equipo de ventas en técnicas de negociación efectivas.",
    "The marketing coordinator is managing social media accounts to engage with customers. \n<color=red>El coordinador de marketing está gestionando cuentas de redes sociales para interactuar con los clientes.",
    "The sales team is attending industry conferences to network and generate leads. \n<color=red>El equipo de ventas está asistiendo a conferencias de la industria para hacer contactos y generar oportunidades.",
    "The marketing director is analyzing consumer feedback to refine product messaging. \n<color=red>El director de marketing está analizando los comentarios de los consumidores para perfeccionar el mensaje del producto.",
    "The sales executive is developing sales forecasts for the upcoming fiscal year. \n<color=red>El ejecutivo de ventas está elaborando pronósticos de ventas para el próximo año fiscal.",
    "The marketing specialist is conducting A/B testing on email subject lines to optimize open rates. \n<color=red>El especialista en marketing está realizando pruebas A/B en líneas de asunto de correos electrónicos para optimizar las tasas de apertura.",
    "The sales team is creating sales collateral to support client presentations. \n<color=red>El equipo de ventas está creando material de apoyo para presentaciones de clientes.",
    "The marketing coordinator is analyzing website analytics to improve user experience. \n<color=red>El coordinador de marketing está analizando las analíticas del sitio web para mejorar la experiencia del usuario.",
    "The sales representative is providing product training to retail staff at partner stores. \n<color=red>El representante de ventas está brindando capacitación sobre productos al personal minorista en tiendas asociadas.",
    "The marketing team is developing influencer partnerships to reach new audiences. \n<color=red>El equipo de marketing está desarrollando asociaciones con influencers para llegar a nuevas audiencias.",
    "The sales manager is implementing a customer relationship management system to track sales leads. \n<color=red>El gerente de ventas está implementando un sistema de gestión de relaciones con los clientes para rastrear oportunidades de ventas.",
    "The marketing coordinator is coordinating the production of promotional videos for social media. \n<color=red>El coordinador de marketing está coordinando la producción de videos promocionales para redes sociales."

};
















    public string[] COLLECTION_textsArray = {
    "Chair - Made out of the wood for the person to sit on \n<color=red>Silla - hecha de madera para que la persona se siente.",

             "Apple - A round fruit with red or green skin and a crisp white flesh \n<color=red>Manzana - una fruta redonda con piel roja o verde y una carne blanca y crujiente.",
    "Car - A vehicle with four wheels that is usually propelled by an internal combustion engine \n<color=red>Coche - un vehículo con cuatro ruedas que generalmente es propulsado por un motor de combustión interna.",
    "House - A building for human habitation, typically one that is detached and surrounded by land \n<color=red>Casa - un edificio para la habitación humana, típicamente uno que está separado y rodeado de tierra.",
    "Ball - A round object that is used in games, sports, and play \n<color=red>Pelota - un objeto redondo que se utiliza en juegos, deportes y juegos.",


    "Cat - A small domesticated carnivorous mammal with soft fur, a short snout, and retractile claws \n<color=red>Gato - un pequeño mamífero carnívoro doméstico con pelaje suave, un hocico corto y garras retráctiles.",
    "Sun - The star around which the Earth orbits, providing light and heat to the Earth \n<color=red>Sol - la estrella alrededor de la cual orbita la Tierra, proporcionando luz y calor a la Tierra.",
    "Moon - The natural satellite of the Earth, visible chiefly at night by reflected light from the sun \n<color=red>Luna - el satélite natural de la Tierra, visible principalmente por la noche por la luz reflejada del sol.",
               "Phone - An electronic device used for making and receiving telephone calls \n<color=red>Teléfono - un dispositivo electrónico utilizado para hacer y recibir llamadas telefónicas.",
    "Bicycle - A vehicle with two wheels propelled by pedals and steered with handlebars \n<color=red>Bicicleta - un vehículo con dos ruedas impulsado por pedales y dirigido con manubrios.",
    "Bird - A warm-blooded vertebrate animal with feathers and wings, typically able to fly \n<color=red>Pájaro - un animal vertebrado de sangre caliente con plumas y alas, típicamente capaz de volar.",
    "Water - A colorless, transparent, odorless liquid that forms the seas, rivers, lakes, and rain \n<color=red>Agua - un líquido incoloro, transparente e inodoro que forma los mares, ríos, lagos y lluvia.",
    "Clock - A device for measuring and displaying time, typically with hands or digits moving continuously \n<color=red>Reloj - un dispositivo para medir y mostrar el tiempo, generalmente con manos o dígitos que se mueven continuamente.",
    "Shoe - A covering for the foot, typically made of leather, fabric, or rubber \n<color=red>Zapato - una cubierta para el pie, generalmente hecha de cuero, tela o goma.",
    "Fish - A limbless cold-blooded vertebrate animal with gills and fins living wholly in water \n<color=red>Pez - un animal vertebrado sin extremidades, de sangre fría, con branquias y aletas que vive completamente en el agua.",
    "Door - A hinged, sliding, or revolving barrier at the entrance to a building, room, or vehicle \n<color=red>Puerta - una barrera articulada, deslizante o giratoria en la entrada de un edificio, habitación o vehículo.",
    "Music - Sound organized in time, typically produced by instruments or voices \n<color=red>Música - sonido organizado en el tiempo, generalmente producido por instrumentos o voces.",
    "Camera - A device used to capture and record still images or video \n<color=red>Cámara - un dispositivo utilizado para capturar y grabar imágenes fijas o video.",
    "Game - An activity or form of entertainment that involves rules, competition, and skill \n<color=red>Juego - una actividad o forma de entretenimiento que involucra reglas, competencia y habilidad.",
    "Movie - A story or event recorded on film or video and shown in a theater or on television \n<color=red>Película - una historia o evento grabado en película o video y mostrado en un teatro o televisión.",
    "Internet - A global network connecting millions of computers, facilitating communication and access to information \n<color=red>Internet - una red global que conecta millones de computadoras, facilitando la comunicación y el acceso a la información.",

     "Cat - A small domesticated carnivorous mammal with soft fur and sharp retractile claws \n<color=red>Gato - un pequeño mamífero carnívoro doméstico con pelaje suave y garras retráctiles afiladas.",
    "Apple - A round fruit with red or green skin and a crisp white flesh \n<color=red>Manzana - una fruta redonda con piel roja o verde y una carne blanca crujiente.",
    "Banana - A long curved fruit with a yellow skin and soft sweet flesh \n<color=red>Plátano - una fruta larga y curva con piel amarilla y carne suave y dulce.",
    "Carrot - A tapering orange-colored root eaten as a vegetable \n<color=red>Zanahoria - una raíz de color naranja que se come como verdura.",
    "Television - An electronic device used for viewing broadcast programs or images \n<color=red>Televisión - un dispositivo electrónico utilizado para ver programas o imágenes emitidos.",


    "Sofa - A long upholstered seat with a back and arms, for two or more people to sit on \n<color=red>Sofá - un asiento largo tapizado con respaldo y brazos, para que dos o más personas se sienten.",
    "Desk - A piece of furniture with a flat or sloped surface for writing, reading, or working \n<color=red>Escritorio - un mueble con una superficie plana o inclinada para escribir, leer o trabajar.",
    "Laptop - A portable computer that is small and lightweight, designed for use while traveling \n<color=red>Portátil - un ordenador portátil que es pequeño y ligero, diseñado para su uso mientras se viaja.",
    "Chicken - A domesticated bird kept for its eggs or meat, or the meat of such a bird \n<color=red>Pollo - un ave doméstica criada por sus huevos o carne, o la carne de tal ave.",
    "Pizza - A dish of Italian origin, consisting of a flat round base of dough topped with cheese, tomatoes, and other ingredients \n<color=red>Pizza - un plato de origen italiano, que consiste en una base plana redonda de masa cubierta con queso, tomates y otros ingredientes.",
    "Bicycle - A vehicle with two wheels and pedals, propelled by the rider's feet \n<color=red>Bicicleta - un vehículo con dos ruedas y pedales, impulsado por los pies del ciclista.",
    "Guitar - A stringed musical instrument played by plucking or strumming the strings \n<color=red>Guitarra - un instrumento musical de cuerda tocado mediante pellizco o rasgueo de las cuerdas.",
    "Hat - A shaped covering for the head, typically with a crown and brim \n<color=red>Gorra - una cobertura formada para la cabeza, generalmente con una corona y ala.",
    "Tree - A woody perennial plant with a single main stem or trunk, typically growing to a considerable height \n<color=red>Árbol - una planta perenne leñosa con un solo tallo principal o tronco, que típicamente crece hasta una altura considerable.",
    "Watch - A small timepiece worn typically on the wrist, used to keep time \n<color=red>Reloj - un pequeño dispositivo para medir el tiempo típicamente usado en la muñeca, utilizado para mantener el tiempo."


};




























    public string[] idleMSGS_textsArray = {
         "The faucet is dripping. \n<color=red>El grifo está goteando.",
    "The light bulb is flickering. \n<color=red>La bombilla está parpadeando.",
    "The refrigerator is making strange noises. \n<color=red>El refrigerador está haciendo ruidos extraños.",
    "The dishwasher is not draining properly. \n<color=red>El lavavajillas no está desagüando correctamente.",
    "The oven door is not closing properly. \n<color=red>La puerta del horno no está cerrando correctamente.",
    "The stove burner won't ignite. \n<color=red>El quemador de la estufa no enciende.",
    "The kitchen floor is slippery. \n<color=red>El piso de la cocina está resbaladizo.",
    "The microwave is not heating food. \n<color=red>El microondas no está calentando la comida.",
    "The coffee maker is not brewing coffee. \n<color=red>La cafetera no está haciendo café.",
    "The cutting board is stained. \n<color=red>La tabla de cortar está manchada.",
      "The kitchen sink is clogged. \n<color=red>El fregadero de la cocina está obstruido.",
    "The oven is emitting a burning smell. \n<color=red>El horno está emitiendo un olor a quemado.",
    "The spice cabinet is disorganized. \n<color=red>El armario de especias está desorganizado.",
    "The refrigerator is not cooling properly. \n<color=red>El refrigerador no está enfriando correctamente.",
    "The blender blade is dull. \n<color=red>La cuchilla de la licuadora está embotada.",
    "The kitchen floor is sticky. \n<color=red>El piso de la cocina está pegajoso.",
    "The timer on the oven is not working. \n<color=red>El temporizador del horno no funciona.",
    "The toaster is not toasting bread evenly. \n<color=red>La tostadora no está tostando el pan uniformemente.",
    "The frying pan handle is loose. \n<color=red>El mango de la sartén está suelto.",
    "The dish soap dispenser is empty. \n<color=red>El dispensador de jabón para platos está vacío.",
       "The kitchen faucet is dripping. \n<color=red>El grifo de la cocina está goteando.",
    "The oven is not heating evenly. \n<color=red>El horno no se está calentando de manera uniforme.",
    "The blender lid is cracked. \n<color=red>La tapa de la licuadora está agrietada.",
    "The cutting board is warped. \n<color=red>La tabla de cortar está torcida.",
    "The refrigerator door doesn't close properly. \n<color=red>La puerta del refrigerador no se cierra correctamente.",
    "The kitchen countertop is stained. \n<color=red>La encimera de la cocina está manchada.",
    "The toaster oven is smoking. \n<color=red>El horno tostador está echando humo.",
    "The microwave display is not working. \n<color=red>La pantalla del microondas no está funcionando.",
    "The dishwasher is not draining water. \n<color=red>El lavavajillas no está desaguando el agua.",
    "The stove knob is loose. \n<color=red>El botón de la estufa está flojo.",


    "The oven temperature needs to be adjusted; it's running too hot. \n<color=red> La temperatura del horno necesita ser ajustada; está funcionando demasiado caliente.",
    "We're short on ingredients for tonight's dinner service. \n<color=red> Nos faltan ingredientes para el servicio de cena de esta noche.",
    "The kitchen exhaust system is malfunctioning; we need to call a technician. \n<color=red> El sistema de extracción de la cocina está fallando; necesitamos llamar a un técnico.",
    "The chef cut himself while chopping vegetables; we need to disinfect the area and apply first aid. \n<color=red> El chef se cortó mientras cortaba verduras; necesitamos desinfectar el área y aplicar primeros auxilios.",
    "The gas burner won't ignite; we need to check the gas supply and the ignition system. \n<color=red> La hornilla de gas no enciende; necesitamos revisar el suministro de gas y el sistema de ignición.",
    "The kitchen floor is slippery; we need to mop it to prevent accidents. \n<color=red> El piso de la cocina está resbaladizo; necesitamos trapearlo para prevenir accidentes.",
    "We're out of stock on several key ingredients; we need to place an urgent order. \n<color=red> Estamos sin existencias de varios ingredientes clave; necesitamos hacer un pedido urgente.",
    "The pastry dough is too dry; we need to add more water to achieve the right consistency. \n<color=red> La masa de pastelería está muy seca; necesitamos agregar más agua para lograr la consistencia adecuada.",
    "The meat needs to marinate for at least two hours before grilling. \n<color=red> La carne necesita marinar durante al menos dos horas antes de asarla.",
    "The dishwasher is leaking; we need to shut it down and call for repairs. \n<color=red> El lavavajillas está goteando; necesitamos apagarlo y llamar para reparaciones.",
        "The mixer is making strange noises; we should stop and check it for any issues. \n<color=red> La batidora está haciendo ruidos extraños; deberíamos detenernos y revisarla en busca de problemas.",
    "The chef accidentally spilled oil on the floor; we need to clean it up immediately to avoid slips. \n<color=red> El chef derramó accidentalmente aceite en el piso; necesitamos limpiarlo de inmediato para evitar resbalones.",
    "The recipe calls for preheating the oven to 350°F; let's turn it on and wait for it to reach the desired temperature. \n<color=red> La receta indica precalentar el horno a 350°F; encendámoslo y esperemos a que alcance la temperatura deseada.",
    "We're out of parchment paper; we'll need to use silicone mats instead for baking. \n<color=red> Nos quedamos sin papel pergamino; necesitaremos usar tapetes de silicona en su lugar para hornear.",
    "The kitchen knives are dull and need to be sharpened; it's affecting the efficiency of food preparation. \n<color=red> Los cuchillos de cocina están desafilados y necesitan ser afilados; está afectando la eficiencia de la preparación de alimentos.",
    "The delivery of fresh produce is delayed; we'll have to adjust our menu accordingly and use alternative ingredients. \n<color=red> La entrega de productos frescos se retrasó; tendremos que ajustar nuestro menú en consecuencia y usar ingredientes alternativos.",
    "The saucepan is overheating; let's turn down the heat to avoid burning the contents. \n<color=red> La cacerola se está sobrecalentando; bajemos el fuego para evitar quemar el contenido.",
    "The timer for the oven is not working; we'll need to keep a close eye on the baking time manually. \n<color=red> El temporizador del horno no funciona; necesitaremos vigilar el tiempo de cocción de cerca manualmente.",
    "The refrigerator door is not sealing properly; we need to adjust the hinges or replace the gasket to maintain the cold temperature inside. \n<color=red> La puerta del refrigerador no se sella correctamente; necesitamos ajustar las bisagras o reemplazar el sello para mantener la temperatura fría en el interior.",
    "The fire alarm went off due to smoke from the grill; we need to ventilate the kitchen and ensure proper airflow. \n<color=red> La alarma de incendios se activó debido al humo de la parrilla; necesitamos ventilar la cocina y asegurar un flujo de aire adecuado.",

};



    //some currency for restaurant clicker   clicker hero with some prestige

    public string[] idleDESCRIPTIONS_textsArray = {
    "Tiramisu - An Italian dessert made with layers of coffee-soaked ladyfingers and mascarpone cheese, dusted with cocoa powder. <color=red>Tiramisú - Un postre italiano hecho con capas de bizcochos de soletilla empapados en café y queso mascarpone, espolvoreado con cacao en polvo.",
    "Sushi - A Japanese dish consisting of vinegared rice combined with various ingredients such as seafood, vegetables, and sometimes tropical fruits, rolled in seaweed and sliced into bite-sized pieces. <color=red>Sushi - Un plato japonés que consiste en arroz avinagrado combinado con varios ingredientes como mariscos, vegetales y a veces frutas tropicales, enrollado en alga nori y cortado en trozos pequeños.",
    "Pasta Carbonara - An Italian pasta dish made with spaghetti, eggs, cheese (typically Pecorino Romano or Parmesan), pancetta, and black pepper. <color=red>Pasta Carbonara - Un plato de pasta italiano hecho con espaguetis, huevos, queso (normalmente Pecorino Romano o Parmesano), panceta y pimienta negra.",
    "Croissant - A buttery, flaky pastry of Austrian origin, made of layered yeast-leavened dough. <color=red>Croissant - Un hojaldre mantecoso y escamoso de origen austriaco, hecho de masa de levadura en capas.",
       "Burger - A classic American dish consisting of a grilled or fried ground meat patty, typically beef, served in a bun with various toppings such as lettuce, tomato, onion, pickles, and condiments. <color=red>Hamburguesa - Un plato clásico estadounidense que consiste en una hamburguesa de carne picada a la parrilla o frita, típicamente de res, servida en un pan con diversos ingredientes como lechuga, tomate, cebolla, pepinillos y condimentos.",
    "Pad Thai - A popular Thai stir-fried noodle dish made with rice noodles, eggs, tofu, shrimp, bean sprouts, peanuts, and a flavorful sauce made from tamarind, fish sauce, garlic, and chili peppers. <color=red>Pad Thai - Un popular plato tailandés de fideos salteados hecho con fideos de arroz, huevos, tofu, camarones, brotes de soja, cacahuetes y una sabrosa salsa hecha de tamarindo, salsa de pescado, ajo y pimientos chile.",
    "Lasagna - An Italian dish consisting of layers of wide flat pasta, ricotta cheese, tomato sauce, and various fillings such as ground meat, vegetables, and herbs, topped with mozzarella cheese and baked until golden and bubbly. <color=red>Lasagna - Un plato italiano que consiste en capas de pasta plana ancha, queso ricotta, salsa de tomate y varios rellenos como carne picada, verduras y hierbas, cubierto con queso mozzarella y horneado hasta que esté dorado y burbujeante.",
   "Pizza Margherita - An iconic Italian pizza topped with tomato sauce, fresh mozzarella cheese, basil leaves, and a drizzle of olive oil, representing the colors of the Italian flag. <color=red>Pizza Margherita - Una icónica pizza italiana cubierta con salsa de tomate, queso mozzarella fresco, hojas de albahaca y un chorrito de aceite de oliva, representando los colores de la bandera italiana.",
    "Pho - A Vietnamese noodle soup consisting of broth, rice noodles, herbs, and meat (usually beef or chicken), garnished with ingredients such as lime, bean sprouts, basil, and chili peppers. <color=red>Pho - Una sopa de fideos vietnamita que consiste en caldo, fideos de arroz, hierbas y carne (generalmente de res o pollo), adornada con ingredientes como lima, brotes de soja, albahaca y pimientos chile.",
    "Ratatouille - A traditional French Provencal stewed vegetable dish made with tomatoes, zucchini, eggplant, bell peppers, onions, garlic, and herbs, typically served as a side dish or over pasta or rice. <color=red>Ratatouille - Un tradicional guiso de verduras provenzal francés hecho con tomates, calabacines, berenjenas, pimientos, cebollas, ajo y hierbas, típicamente servido como acompañamiento o sobre pasta o arroz.",
    "Gyoza - Japanese dumplings filled with ground meat (usually pork), cabbage, garlic, ginger, and other seasonings, wrapped in thin dough and pan-fried or steamed, often served with a dipping sauce. <color=red>Gyoza - Dumplings japoneses rellenos de carne picada (generalmente cerdo), col, ajo, jengibre y otras especias, envueltos en masa fina y fritos en sartén o al vapor, a menudo servidos con salsa para mojar.",
    "Moussaka - A traditional Greek dish consisting of layers of eggplant, potato, ground meat (usually lamb or beef), onions, tomatoes, and a creamy béchamel sauce, baked until golden brown and bubbling. <color=red>Moussaka - Un plato tradicional griego que consiste en capas de berenjena, patata, carne picada (generalmente cordero o vacuno), cebolla, tomate y una cremosa salsa bechamel, horneado hasta que esté dorado y burbujeante.",
    "Croissant - A buttery, flaky pastry of Austrian origin, made of layered yeast-leavened dough. <color=red>Croissant - Un hojaldre mantecoso y escamoso de origen austriaco, hecho de masa de levadura en capas.",
    "Paella - A Spanish rice dish originating from Valencia, typically made with short-grain rice, saffron, various meats such as chicken, rabbit, and seafood like shrimp, mussels, and clams, cooked in a wide shallow pan and often flavored with paprika and other spices. <color=red>Paella - Un plato de arroz español originario de Valencia, típicamente hecho con arroz de grano corto, azafrán, varias carnes como pollo, conejo y mariscos como camarones, mejillones y almejas, cocidos en una sartén ancha y poco profunda y a menudo sazonados con pimentón y otras especias.",
    "Gelato - An Italian frozen dessert similar to ice cream but made with a higher proportion of milk and a lower proportion of cream and eggs, resulting in a denser and creamier texture. Gelato comes in a variety of flavors such as chocolate, vanilla, pistachio, and fruit flavors. <color=red>Gelato - Un postre helado italiano similar al helado pero hecho con una mayor proporción de leche y una menor proporción de crema y huevos, lo que resulta en una textura más densa y cremosa. El gelato viene en una variedad de sabores como chocolate, vainilla, pistacho y sabores de frutas.",
    "Tacos al Pastor - A popular Mexican street food dish consisting of thinly sliced pork marinated in a blend of spices, such as achiote, chili peppers, and pineapple juice, cooked on a vertical rotisserie and served on small corn tortillas with onion, cilantro, and pineapple. <color=red>Tacos al Pastor - Un popular plato de comida callejera mexicana que consiste en carne de cerdo cortada en rodajas finas marinada en una mezcla de especias como achiote, pimientos chile y jugo de piña, cocida en un asador vertical y servida en pequeñas tortillas de maíz con cebolla, cilantro y piña.",
       "Croque Monsieur - A classic French grilled sandwich made with ham and cheese, typically Gruyère or Emmental, served on crusty bread and topped with béchamel sauce and more cheese, then grilled or baked until golden and bubbly. <color=red>Croque Monsieur - Un clásico sándwich francés a la parrilla hecho con jamón y queso, típicamente Gruyère o Emmental, servido en pan crujiente y cubierto con salsa bechamel y más queso, luego asado o horneado hasta que esté dorado y burbujeante.",
    "Kebab - A Middle Eastern dish made with seasoned meat, such as lamb, beef, or chicken, skewered and grilled or roasted, often served with pita bread, salad, and a variety of sauces and condiments. <color=red>Kebab - Un plato del Medio Oriente hecho con carne sazonada, como cordero, res o pollo, ensartada y asada o asada, a menudo servida con pan pita, ensalada y una variedad de salsas y condimentos.",
    "Fish and Chips - A classic British dish consisting of battered and deep-fried fish, typically cod or haddock, served with thick-cut fries (chips), mushy peas, tartar sauce, and sometimes malt vinegar. <color=red>Pescado y papas fritas - Un clásico plato británico que consiste en pescado rebozado y frito en aceite, típicamente bacalao o eglefino, servido con papas fritas gruesas (chips), puré de guisantes, salsa tártara y a veces vinagre de malta.",
    "Hummus - A Middle Eastern dip or spread made from cooked, mashed chickpeas blended with tahini (sesame paste), lemon juice, garlic, olive oil, and spices, typically served with pita bread or fresh vegetables. <color=red>Hummus - Un dip o untado del Medio Oriente hecho a partir de garbanzos cocidos y machacados mezclados con tahini (pasta de sésamo), jugo de limón, ajo, aceite de oliva y especias, típicamente servido con pan pita o verduras frescas.",
    "Risotto - An Italian rice dish cooked with broth until creamy, flavored with ingredients such as butter, onion, white wine, and Parmesan cheese, often enhanced with additional ingredients like mushrooms, seafood, or vegetables. <color=red>Risotto - Un plato de arroz italiano cocido con caldo hasta que esté cremoso, condimentado con ingredientes como mantequilla, cebolla, vino blanco y queso parmesano, a menudo mejorado con ingredientes adicionales como champiñones, mariscos o vegetales.",
    "Fajitas - A Tex-Mex dish consisting of grilled strips of marinated meat (usually beef, chicken, or shrimp), served with sautéed onions and bell peppers, tortillas, guacamole, sour cream, salsa, and other condiments, allowing diners to assemble their own wraps. <color=red>Fajitas - Un plato tex-mex que consiste en tiras de carne marinada a la parrilla (generalmente res, pollo o camarones), servida con cebollas y pimientos salteados, tortillas, guacamole, crema agria, salsa y otros condimentos, permitiendo a los comensales armar sus propios wraps.",
    "Pavlova - A meringue-based dessert named after the Russian ballerina Anna Pavlova, consisting of a crispy meringue shell topped with whipped cream and fresh fruit such as strawberries, kiwi, and passionfruit, creating a light and airy yet indulgent treat. <color=red>Pavlova - Un postre a base de merengue nombrado en honor a la bailarina rusa Anna Pavlova, que consiste en una cáscara crujiente de merengue cubierta con crema batida y frutas frescas como fresas, kiwi y maracuyá, creando un bocadillo ligero y aireado pero indulgente.",
    "Beef Wellington - A classic British dish consisting of tender beef fillet coated with pâté and duxelles (a mixture of finely chopped mushrooms, onions, shallots, and herbs), wrapped in puff pastry and baked until golden brown, typically served with a rich red wine sauce. <color=red>Beef Wellington - Un plato clásico británico que consiste en filete de ternera tierno recubierto con paté y duxelles (una mezcla de champiñones finamente picados, cebollas, chalotas y hierbas), envuelto en hojaldre y horneado hasta que esté dorado, típicamente servido con una rica salsa de vino tinto.",
    "Shakshuka - A North African and Middle Eastern dish consisting of poached eggs in a spicy tomato and pepper sauce, flavored with garlic, onions, cumin, paprika, and other spices, often served with crusty bread for dipping. <color=red>Shakshuka - Un plato del norte de África y del Medio Oriente que consiste en huevos escalfados en una salsa picante de tomate y pimiento, condimentada con ajo, cebollas, comino, pimentón y otras especias, a menudo servida con pan crujiente para mojar.",
    "Poutine - A Canadian dish originating from Quebec, consisting of french fries topped with cheese curds and smothered in gravy, creating a savory and indulgent comfort food. <color=red>Poutine - Un plato canadiense originario de Quebec, que consiste en papas fritas cubiertas con trozos de queso fresco y bañadas en salsa de carne, creando un plato reconfortante y sabroso.",
        "Peking Duck - A Chinese dish prized for its crispy skin and tender meat, traditionally served with thin pancakes, scallions, cucumber, and hoisin sauce for wrapping. <color=red>Pato a la pekinesa - Un plato chino apreciado por su piel crujiente y carne tierna, tradicionalmente servido con finas tortillas, cebollines, pepino y salsa hoisin para envolver.",
    "Caesar Salad - A classic salad made with romaine lettuce, croutons, Parmesan cheese, and a dressing of olive oil, lemon juice, anchovies, garlic, Worcestershire sauce, and egg yolk, often served with grilled chicken or shrimp. <color=red>Ensalada César - Una ensalada clásica hecha con lechuga romana, picatostes, queso parmesano y aderezo de aceite de oliva, jugo de limón, anchoas, ajo, salsa Worcestershire y yema de huevo, a menudo servida con pollo o camarones a la parrilla.",
      "Gazpacho - A cold Spanish soup made from blended vegetables such as tomatoes, cucumbers, bell peppers, onions, and garlic, seasoned with olive oil, vinegar, and herbs, served chilled and often garnished with croutons or diced vegetables. <color=red>Gazpacho - Una sopa fría española hecha a partir de vegetales triturados como tomates, pepinos, pimientos, cebollas y ajo, sazonada con aceite de oliva, vinagre y hierbas, servida fría y a menudo adornada con picatostes o vegetales cortados en dados.",
    "Bagel with Lox - A classic Jewish-American breakfast or brunch dish consisting of a bagel topped with cream cheese, smoked salmon (lox), red onion slices, capers, and sometimes tomato slices, typically served open-faced. <color=red>Bagel con Lox - Un clásico desayuno o brunch judío-americano que consiste en un bagel cubierto con queso crema, salmón ahumado (lox), rodajas de cebolla roja, alcaparras y a veces rodajas de tomate, típicamente servido abierto.",
     "Eggs Benedict - A classic brunch dish consisting of poached eggs served on toasted English muffins with Canadian bacon or ham, topped with hollandaise sauce and often garnished with chopped chives or parsley. <color=red>Eggs Benedict - Un plato clásico de brunch que consiste en huevos escalfados servidos sobre panecillos ingleses tostados con tocino canadiense o jamón, cubiertos con salsa holandesa y a menudo adornados con cebollino o perejil picado.",
    "Goulash - A hearty Hungarian stew made with beef, onions, bell peppers, tomatoes, and paprika, simmered until the meat is tender and the flavors are rich and comforting. <color=red>Goulash - Un abundante estofado húngaro hecho con carne de res, cebollas, pimientos, tomates y pimentón, cocido a fuego lento hasta que la carne esté tierna y los sabores sean ricos y reconfortantes.",
    "Mochi - A Japanese rice cake made from glutinous rice pounded into a paste, molded into various shapes, and often filled with sweet fillings such as red bean paste or ice cream. <color=red>Mochi - Un pastel de arroz japonés hecho de arroz glutinoso machacado en una pasta, moldeado en varias formas y a menudo relleno de rellenos dulces como pasta de frijol rojo o helado.",
    "Ceviche - A popular Latin American dish of raw fish or seafood marinated in citrus juices, such as lime or lemon, mixed with onions, tomatoes, cilantro, and chili peppers, served as a refreshing and tangy appetizer. <color=red>Ceviche - Un plato latinoamericano popular de pescado o mariscos crudos marinados en jugos cítricos, como lima o limón, mezclados con cebollas, tomates, cilantro y pimientos chile, servidos como un aperitivo refrescante y picante.",
    "Baklava - A sweet pastry of Middle Eastern origin made with layers of phyllo dough, chopped nuts (such as walnuts or pistachios), butter, and honey or syrup, baked until golden and crispy. <color=red>Baklava - Un dulce de origen medio oriental hecho con capas de masa filo, nueces picadas (como nueces o pistachos), mantequilla y miel o jarabe, horneado hasta que esté dorado y crujiente.",
    "Sauerbraten - A German pot roast dish made with marinated beef, typically seasoned with vinegar, water, sugar, and spices such as cloves, juniper berries, and bay leaves, slow-cooked until tender and served with gravy. <color=red>Sauerbraten - Un plato alemán de carne asada hecho con carne de res marinada, típicamente sazonada con vinagre, agua, azúcar y especias como clavo de olor, bayas de enebro y hojas de laurel, cocida a fuego lento hasta que esté tierna y servida con salsa.",
    "Tzatziki - A Greek sauce or dip made with strained yogurt, cucumbers, garlic, olive oil, vinegar, and dill or mint, often served as a condiment with grilled meats, gyros, or as a dip for vegetables and bread. <color=red>Tzatziki - Una salsa o dip griego hecho con yogur colado, pepinos, ajo, aceite de oliva, vinagre y eneldo o menta, a menudo servido como condimento con carnes a la parrilla, gyros o como dip para verduras y pan.",
    "Churros - A popular Spanish and Latin American fried pastry made from choux dough, typically extruded through a star-shaped nozzle to form long strips, fried until golden and crispy, then dusted with sugar and cinnamon and served with chocolate sauce for dipping. <color=red>Churros - Un popular pastel frito español y latinoamericano hecho con masa choux, típicamente extruido a través de una boquilla con forma de estrella para formar tiras largas, frito hasta que esté dorado y crujiente, luego espolvoreado con azúcar y canela y servido con salsa de chocolate para mojar.",


};



    public string[] MONSTERRPG_textsArray = {
    "Goblin - A small, green-skinned creature known for its mischievous behavior. \n<color=red>Goblin - Una pequeña criatura de piel verde conocida por su comportamiento travieso.",
    "Troll - A large, brutish monster with tough, rocky skin and a club-like weapon. \n<color=red>Trol - Un monstruo grande y brutal con piel dura y rocosa y un arma en forma de garrote.",
    "Orc - A muscular humanoid with greenish skin, often depicted as fierce warriors. \n<color=red>Orco - Un humanoide musculoso con piel verdosa, a menudo representado como guerreros feroces.",
    "Dragon - A legendary creature with scales, wings, and the ability to breathe fire. \n<color=red>Dragón - Una criatura legendaria con escamas, alas y la capacidad de lanzar fuego.",
    "Werewolf - A human who transforms into a wolf-like creature during the full moon. \n<color=red>Hombre lobo - Un humano que se transforma en una criatura similar a un lobo durante la luna llena.",
    "Vampire - A creature that feeds on the blood of the living, often portrayed as aristocratic and immortal. \n<color=red>Vampiro - Una criatura que se alimenta de la sangre de los vivos, a menudo retratada como aristocrática e inmortal.",
    "Zombie - A reanimated corpse that feeds on the flesh of the living. \n<color=red>Zombi - Un cadáver reanimado que se alimenta de la carne de los vivos.",
    "Ghost - The spirit of a deceased person, often portrayed as translucent and haunting specific locations. \n<color=red>Fantasma - El espíritu de una persona fallecida, a menudo representado como translúcido y acechando lugares específicos.",
             "Skeleton - A reanimated skeleton often depicted as wielding weapons and serving necromancers. \n<color=red>Esqueleto - Un esqueleto reanimado a menudo representado como empuñando armas y sirviendo a nigromantes.",
    "Cyclops - A giant creature with a single eye in the middle of its forehead, known for its strength. \n<color=red>Cíclope - Una criatura gigante con un solo ojo en el centro de su frente, conocida por su fuerza.",
    "Minotaur - A half-man, half-bull creature residing in labyrinthine structures, often portrayed as aggressive. \n<color=red>Minotauro - Una criatura mitad hombre, mitad toro que reside en estructuras laberínticas, a menudo representada como agresiva.",
    "Banshee - A female spirit known for her wailing cry, believed to herald death. \n<color=red>Banshee - Un espíritu femenino conocido por su grito de lamento, se cree que anuncia la muerte.",
    "Hydra - A multi-headed serpent-like monster, with regenerative abilities, often depicted as guarding treasure. \n<color=red>Hidra - Un monstruo serpenteante con múltiples cabezas y habilidades regenerativas, a menudo representado como guardián de tesoros.",
    "Succubus - A female demon believed to seduce men in their dreams, draining their life force. \n<color=red>Súcubo - Un demonio femenino que se cree que seduce a los hombres en sus sueños, drenando su fuerza vital.",
    "Incubus - A male demon counterpart to the succubus, believed to seduce women in their dreams. \n<color=red>Íncubo - Un contraparte masculino del súcubo, se cree que seduce a las mujeres en sus sueños.",
    "Griffin - A mythical creature with the body of a lion and the head and wings of an eagle, known for its strength and nobility. \n<color=red>Grifo - Una criatura mítica con el cuerpo de un león y la cabeza y alas de un águila, conocida por su fuerza y nobleza.",
    "Wraith - An undead spirit or ghost, often associated with vengeance and haunting specific individuals. \n<color=red>Espectro - Un espíritu o fantasma no muerto, a menudo asociado con la venganza y acechando a individuos específicos.",
    "Chimera - A monstrous creature with the body parts of various animals, known for its ferocity and unpredictability. \n<color=red>Quimera - Una criatura monstruosa con las partes del cuerpo de varios animales, conocida por su ferocidad e imprevisibilidad.",
       "Wendigo - A malevolent spirit or creature from Algonquian folklore, associated with cannibalism and the cold wilderness. \n<color=red>Wendigo - Un espíritu o criatura maligna del folclore algonquino, asociado con el canibalismo y los fríos parajes salvajes.",
    "Basilisk - A legendary reptile known for its deadly gaze, said to be able to kill with a single glance. \n<color=red>Basilisco - Un reptil legendario conocido por su mirada mortal, se dice que puede matar con una sola mirada.",
    "Sphinx - A mythical creature with the body of a lion and the head of a human, known for its riddles and wisdom. \n<color=red>Esfinge - Una criatura mítica con el cuerpo de un león y la cabeza de un humano, conocida por sus acertijos y sabiduría.",
    "Kelpie - A shape-shifting water spirit from Celtic folklore, often appearing as a horse and luring travelers to their doom. \n<color=red>Kelpie - Un espíritu acuático cambiaformas del folclore celta, que a menudo aparece como un caballo y atrae a los viajeros hacia su perdición.",
    "Manticore - A legendary creature with the body of a lion, the head of a human, and the tail of a scorpion, known for its voracious appetite. \n<color=red>Mánticores - Criaturas legendarias con el cuerpo de un león, la cabeza de un humano y la cola de un escorpión, conocidas por su apetito voraz.",
    "Bogeyman - A mythical creature used to frighten children, often depicted as a sinister figure lurking in the dark. \n<color=red>Hombre del saco - Una criatura mítica utilizada para asustar a los niños, a menudo representada como una figura siniestra que acecha en la oscuridad.",
    "Kraken - A legendary sea monster of giant proportions, said to dwell off the coasts of Norway and Greenland. \n<color=red>Kraken - Un monstruo marino legendario de proporciones gigantescas, se dice que habita frente a las costas de Noruega y Groenlandia.",
    "Gorgon - A mythical creature with snakes for hair, whose gaze turns onlookers to stone, famously embodied by Medusa. \n<color=red>Gorgona - Una criatura mítica con serpientes en lugar de cabello, cuya mirada convierte a los espectadores en piedra, famosamente encarnada por Medusa.",
    "Chupacabra - A legendary creature in Latin American folklore, said to attack and drink the blood of livestock. \n<color=red>Chupacabra - Una criatura legendaria del folclore latinoamericano, se dice que ataca y bebe la sangre del ganado.",
    "Banshee - A female spirit in Irish folklore, believed to wail or scream to foretell death. \n<color=red>Banshee - Un espíritu femenino en el folclore irlandés, se cree que lamenta o grita para prever la muerte.",
               "Siren - A mythical creature often depicted as a beautiful woman whose singing lures sailors to their doom. \n<color=red>Sirena - Una criatura mítica a menudo representada como una mujer hermosa canto atrae a los marineros hacia su perdición.",
    "Ghoul - A creature from Arabic folklore that robs graves and feeds on corpses. \n<color=red>Ghoul - Una criatura del folclore árabe que roba tumbas y se alimenta de cadáveres.",
    "Yeti - A legendary ape-like creature said to inhabit the Himalayan mountains, also known as the Abominable Snowman. \n<color=red>Yeti - Una criatura legendaria similar a un mono, se dice que habita en las montañas del Himalaya, también conocida como el Abominable Hombre de las Nieves.",
    "Phoenix - A mythical bird that cyclically regenerates or is reborn from its ashes. \n<color=red>Fénix - Un pájaro mítico que se regenera cíclicamente o renace de sus cenizas.",
    "Djinn - A supernatural creature in Islamic mythology, often capable of granting wishes or causing mischief. \n<color=red>Djinn - Una criatura sobrenatural en la mitología islámica, a menudo capaz de conceder deseos o causar travesuras.",
    "Boggart - A mischievous household spirit from English folklore, known for causing disruptions. \n<color=red>Boggart - Un espíritu travieso del folclore inglés, conocido por causar alteraciones.",
    "Centaur - A mythical creature with the upper body of a human and the lower body of a horse. \n<color=red>Centauro - Una criatura mítica con la parte superior de un humano y la parte inferior de un caballo.",
    "Doppelgänger - A paranormal duplicate of a living person, often considered a harbinger of bad luck. \n<color=red>Doppelgänger - Un duplicado paranormal de una persona viva, a menudo considerado un presagio de mala suerte.",
    "Mummy - A preserved corpse, often wrapped in bandages, from ancient Egyptian culture, sometimes believed to come back to life. \n<color=red>Momia - Un cadáver preservado, a menudo envuelto en vendas, de la cultura egipcia antigua, a veces se cree que vuelve a la vida.",
    "Gremlin - A mischievous creature known for sabotaging machinery and causing technical malfunctions. \n<color=red>Gremlin - Una criatura traviesa conocida por sabotear maquinaria y causar fallas técnicas."


};



    public string[] battleMSGS_textsArray = {
    "We're low on potions. \n<color=red>Nos quedan pociones.",
    "The adventurers are tired. \n<color=red>Los aventureros están cansados.",
    "We need more supplies. \n<color=red>Necesitamos más suministros.",
    "The party is injured. \n<color=red>El grupo está herido.",
    "Our weapons are dull. \n<color=red>Nuestras armas están desafiladas.",
    "The monster is strong. \n<color=red>El monstruo es fuerte.",
    "We're in danger. \n<color=red>Estamos en peligro.",
    "Our spells are weak. \n<color=red>Nuestros hechizos son débiles.",
    "The enemy is fierce. \n<color=red>El enemigo es feroz.",
    "We need reinforcements. \n<color=red>Necesitamos refuerzos.",
    "The fight is intense. \n<color=red>La lucha es intensa.",
    "We're outnumbered. \n<color=red>Estamos en desventaja numérica.",
    "The monster is wounded. \n<color=red>El monstruo está herido.",
    "We're surrounded. \n<color=red>Estamos rodeados.",
    "Our defenses are failing. \n<color=red>Nuestras defensas están fallando.",
    "The battle is chaotic. \n<color=red>La batalla es caótica.",
    "We're struggling to keep up. \n<color=red>Estamos luchando para seguir adelante.",
    "The enemy is relentless. \n<color=red>El enemigo es implacable.",
    "We need to retreat. \n<color=red>Necesitamos retirarnos.",
    "The monster is enraged. \n<color=red>El monstruo está enfurecido.",
    "We're losing ground. \n<color=red>Estamos perdiendo terreno.",
    "Our defenses are holding. \n<color=red>Nuestras defensas están aguantando.",
    "The party is resilient. \n<color=red>El grupo es resistente.",
    "We're making progress. \n<color=red>Estamos avanzando.",
    "The enemy is weakening. \n<color=red>El enemigo se está debilitando.",
    "We're fighting back. \n<color=red>Estamos contraatacando.",
    "The monster is retreating. \n<color=red>El monstruo está retrocediendo.",
    "We're gaining ground. \n<color=red>Estamos ganando terreno.",
    "The enemy is in disarray. \n<color=red>El enemigo está en desorden.",
    "Victory is within reach. \n<color=red>La victoria está al alcance.",
             "We're running low on healing potions. \n<color=red>Nos estamos quedando sin pociones de curación.",
    "The adventurers are exhausted from battling the dragon. \n<color=red>Los aventureros están exhaustos de luchar contra el dragón.",
    "We need more mana potions for the upcoming boss fight. \n<color=red>Necesitamos más pociones de maná para la próxima pelea contra el jefe.",
    "The party's cleric is casting healing spells to keep everyone alive. \n<color=red>El clérigo del grupo está lanzando hechizos de curación para mantener a todos con vida.",
    "Our warriors are equipped with enchanted weapons for extra damage. \n<color=red>Nuestros guerreros están equipados con armas encantadas para causar más daño.",
    "The rogue is sneaking behind the monster for a surprise attack. \n<color=red>El pícaro se está colando detrás del monstruo para un ataque sorpresa.",
    "The mage is channeling elemental magic to weaken the creature's defenses. \n<color=red>El mago está canalizando magia elemental para debilitar las defensas de la criatura.",
    "Our tank is bravely holding aggro to protect the rest of the party. \n<color=red>Nuestro tanque está valientemente sosteniendo la atención para proteger al resto del grupo.",
    "The ranger is using precision shots to target the monster's weak spots. \n<color=red>El guardabosques está usando disparos precisos para apuntar a los puntos débiles del monstruo.",
    "The bard's inspiring melodies boost morale and combat effectiveness. \n<color=red>Las melodías inspiradoras del bardo aumentan la moral y la eficacia en combate.",
    "We're in urgent need of more antidotes for the venomous creatures in the area. \n<color=red>Necesitamos con urgencia más antídotos para las criaturas venenosas en la zona.",
    "The monster's roar sends shivers down the spine of the bravest warrior. \n<color=red>El rugido del monstruo hace temblar hasta al guerrero más valiente.",
    "Our cleric is calling upon divine intervention to turn the tide of battle. \n<color=red>Nuestro clérigo está invocando una intervención divina para cambiar el rumbo de la batalla.",
    "The party's morale is high as they prepare for the final showdown. \n<color=red>La moral del grupo está alta mientras se preparan para el enfrentamiento final.",
    "We've encountered a horde of undead minions led by a powerful necromancer. \n<color=red>Nos hemos encontrado con una horda de secuaces no muertos liderados por un poderoso nigromante.",
    "Our ranger's keen senses detect an ambush waiting ahead. \n<color=red>Los sentidos agudos de nuestro guardabosques detectan una emboscada esperando más adelante.",
    "The paladin's divine shield protects the party from the dragon's fiery breath. \n<color=red>El escudo divino del paladín protege al grupo del aliento de fuego del dragón.",
    "Our mage is preparing a powerful AoE spell to deal with the swarm of monsters. \n<color=red>Nuestro mago está preparando un poderoso hechizo de área para lidiar con la horda de monstruos.",
    "The party's rogue successfully disarms a trap set by cunning goblins. \n<color=red>El pícaro del grupo desactiva con éxito una trampa colocada por astutos goblins.",
    "Our tank's heavy armor absorbs the brunt of the ogre's club attack. \n<color=red>La pesada armadura de nuestro tanque absorbe la mayor parte del ataque del garrote del ogro.",
    "The party's bard sings a captivating melody to mesmerize the enemy. \n<color=red>El bardo del grupo canta una melodía cautivadora para hipnotizar al enemigo.",
    "Our cleric's holy light sears through the darkness, revealing hidden enemies. \n<color=red>La luz sagrada de nuestro clérigo atraviesa la oscuridad, revelando enemigos ocultos.",
    "The party's wizard conjures a protective barrier to shield against incoming spells. \n<color=red>El mago del grupo conjura una barrera protectora para protegerse contra los hechizos entrantes.",
    "Our warrior's mighty blows chip away at the dragon's armored scales. \n<color=red>Los poderosos golpes de nuestro guerrero erosionan las escamas blindadas del dragón.",
    "The ranger's swift arrows find their mark, striking true against the enemy. \n<color=red>Las flechas rápidas del guardabosques encuentran su objetivo, golpeando con certeza al enemigo.",
    "The paladin's righteous fury smites the undead with holy power. \n<color=red>La furia justiciera del paladín golpea a los no muertos con poder divino.",
    "Our mage's elemental barrage overwhelms the enemy forces with magic. \n<color=red>El bombardeo elemental de nuestro mago abruma a las fuerzas enemigas con magia.",
    "The party's rogue delivers a decisive strike, felling the enemy leader. \n<color=red>El pícaro del grupo realiza un golpe decisivo, derribando al líder enemigo.",
    "Our tank's unyielding resolve inspires courage in the face of danger. \n<color=red>La firme determinación de nuestro tanque inspira coraje frente al peligro.",
    "The cleric's healing prayers restore vitality to wounded comrades. \n<color=red>Las oraciones curativas del clérigo restauran vitalidad en compañeros heridos.",
    "The party's morale remains strong as they press onward in their quest. \n<color=red>La moral del grupo sigue siendo fuerte mientras avanzan en su búsqueda."

};


























    public string[] collisionCLICKERMSGS_textsArray = {
    "We need an enchanted hammer to break through this magical barrier. \n<color=red>Necesitamos un martillo encantado para romper esta barrera mágica.",
    "The hammer infused with arcane energy is chipping away at the enchanted stone. \n<color=red>El martillo imbuido de energía arcana está desgastando la piedra encantada.",
    "We're using a hammer enchanted with lightning magic to shatter the crystal. \n<color=red>Estamos usando un martillo encantado con magia de relámpagos para hacer añicos el cristal.",
    "The hammer strikes imbued with elemental magic are cracking the ancient seal. \n<color=red>Los golpes del martillo imbuidos con magia elemental están resquebrajando el sello antiguo.",
    "We need a celestial hammer to break through the barrier between realms. \n<color=red>Necesitamos un martillo celestial para romper la barrera entre los reinos.",
    "The hammer blessed by the gods is chipping away at the cursed stone. \n<color=red>El martillo bendecido por los dioses está desgastando la piedra maldita.",
    "We're using a hammer enchanted with fire magic to melt through the ice wall. \n<color=red>Estamos usando un martillo encantado con magia de fuego para derretir la pared de hielo.",
    "The hammer strikes infused with shadow magic are weakening the dark barrier. \n<color=red>Los golpes del martillo imbuidos con magia de sombras están debilitando la barrera oscura.",
    "We need a hammer forged from celestial steel to shatter the demon's shield. \n<color=red>Necesitamos un martillo forjado de acero celestial para hacer añicos el escudo del demonio.",
    "The hammer empowered by ancient runes is cracking the enchanted armor. \n<color=red>El martillo potenciado por runas antiguas está resquebrajando la armadura encantada.",
    "We're using a hammer imbued with earth magic to break through the barrier of vines. \n<color=red>Estamos usando un martillo imbuido con magia de tierra para romper la barrera de enredaderas.",
    "The hammer strikes infused with celestial energy are breaking the barrier between dimensions. \n<color=red>Los golpes del martillo imbuidos con energía celestial están rompiendo la barrera entre dimensiones.",
    "We need a hammer empowered by the elements to shatter the elemental golem's core. \n<color=red>Necesitamos un martillo potenciado por los elementos para hacer añicos el núcleo del gólem elemental.",
    "The hammer enchanted with frost magic is chipping away at the fiery wall. \n<color=red>El martillo encantado con magia de escarcha está desgastando la pared ardiente.",
    "We're using a hammer infused with healing magic to break the cursed seal. \n<color=red>Estamos usando un martillo imbuido con magia de curación para romper el sello maldito.",
    "The hammer strikes empowered by dragonfire are shattering the ancient crystal. \n<color=red>Los golpes del martillo potenciados por fuego de dragón están haciendo añicos el cristal antiguo.",
    "We need a celestial hammer to break through the barrier of darkness. \n<color=red>Necesitamos un martillo celestial para romper la barrera de oscuridad.",
    "The hammer blessed by the spirits is chipping away at the cursed stone. \n<color=red>El martillo bendecido por los espíritus está desgastando la piedra maldita.",
    "We're using a hammer enchanted with thunder magic to shatter the arcane shield. \n<color=red>Estamos usando un martillo encantado con magia de trueno para hacer añicos el escudo arcáno.",
    "The hammer strikes imbued with elemental energy are weakening the magical barrier. \n<color=red>Los golpes del martillo imbuidos con energía elemental están debilitando la barrera mágica.",
    "We need a hammer forged from celestial steel to break through the barrier of shadows. \n<color=red>Necesitamos un martillo forjado de acero celestial para romper la barrera de sombras.",
      "We're using a hammer infused with spectral energy to break the ghostly barrier. \n<color=red>Estamos usando un martillo imbuido con energía espectral para romper la barrera fantasmal.",
    "The hammer strikes empowered by celestial light are cracking the cursed crystal. \n<color=red>Los golpes del martillo potenciados por la luz celestial están resquebrajando el cristal maldito.",
    "We need a hammer forged from dragonbone to shatter the enchanted shield. \n<color=red>Necesitamos un martillo forjado de hueso de dragón para hacer añicos el escudo encantado.",
    "The hammer enchanted with eldritch magic is chipping away at the ancient ward. \n<color=red>El martillo encantado con magia arcania está desgastando el sello antiguo.",
    "We're using a hammer infused with faerie dust to break the illusionary wall. \n<color=red>Estamos usando un martillo imbuido con polvo de hadas para romper la pared ilusoria.",
    "The hammer strikes empowered by elemental fury are shattering the magical barrier. \n<color=red>Los golpes del martillo potenciados por la furia elemental están haciendo añicos la barrera mágica.",
    "We need a hammer forged from meteorite to breach the celestial barrier. \n<color=red>Necesitamos un martillo forjado de meteorito para atravesar la barrera celestial.",
    "The hammer imbued with infernal flames is chipping away at the cursed obelisk. \n<color=red>El martillo imbuido con llamas infernales está desgastando el obelisco maldito.",
    "We're using a hammer enchanted with time magic to break the temporal barrier. \n<color=red>Estamos usando un martillo encantado con magia del tiempo para romper la barrera temporal.",
    "The hammer strikes infused with druidic energy are cracking the ancient tree's roots. \n<color=red>Los golpes del martillo imbuidos con energía druídica están resquebrajando las raíces del árbol antiguo.",
    "We need a hammer forged from starlight to break the ethereal barrier. \n<color=red>Necesitamos un martillo forjado de luz estelar para romper la barrera etérea.",
    "The hammer blessed by the spirits of nature is chipping away at the cursed stone. \n<color=red>El martillo bendecido por los espíritus de la naturaleza está desgastando la piedra maldita.",
    "We're using a hammer infused with arcane runes to shatter the magical ward. \n<color=red>Estamos usando un martillo imbuido con runas arcanas para hacer añicos la protección mágica.",
    "The hammer strikes empowered by the fury of the storm are cracking the elemental barrier. \n<color=red>Los golpes del martillo potenciados por la furia de la tormenta están resquebrajando la barrera elemental.",
    "We need a hammer forged from the heart of a mountain to break the earth's barrier. \n<color=red>Necesitamos un martillo forjado del corazón de una montaña para romper la barrera terrenal.",
    "The hammer enchanted with celestial blessings is chipping away at the cursed artifact. \n<color=red>El martillo encantado con bendiciones celestiales está desgastando el artefacto maldito.",
    "We're using a hammer infused with lunar magic to break the barrier of darkness. \n<color=red>Estamos usando un martillo imbuido con magia lunar para romper la barrera de oscuridad.",
    "The hammer strikes empowered by the breath of dragons are shattering the ancient barrier. \n<color=red>Los golpes del martillo potenciados por el aliento de dragones están haciendo añicos la barrera antigua.",
    "We need a hammer forged from the tears of a phoenix to breach the celestial veil. \n<color=red>Necesitamos un martillo forjado de las lágrimas de un fénix para atravesar el velo celestial.",
    "The hammer imbued with the essence of the sun is chipping away at the cursed ice. \n<color=red>El martillo imbuido con la esencia del sol está desgastando el hielo maldito."

};























    public string[] collisionCLICKERUPGRADEDESCRIPTIONS_textsArray = {
    "Craftsman's Hammer - A versatile tool for various construction tasks. \n<color=red>Martillo del artesano - Una herramienta versátil para varias tareas de construcción.",
    "Apprentice's Mallet - A basic hammer suitable for beginners. \n<color=red>Mazo del aprendiz - Un martillo básico adecuado para principiantes.",
    "Novice Maul - A sturdy hammer for entry-level construction work. \n<color=red>Maza del novato - Un martillo resistente para trabajos de construcción de nivel básico.",
    "Worker's Sledge - A heavy-duty hammer for labor-intensive tasks. \n<color=red>Maza del trabajador - Un martillo resistente para tareas laboriosas.",
    "Stonemason's Hammer - A specialized hammer for shaping stone. \n<color=red>Martillo del cantero - Un martillo especializado para dar forma a la piedra.",
    "Ironclad Warhammer - A powerful hammer for forging metal. \n<color=red>Martillo de guerra acorazado - Un poderoso martillo para forjar metal.",
    "Steelsmith's Maul - A robust hammer crafted for steelworking. \n<color=red>Maza del herrero de acero - Un martillo robusto diseñado para trabajar el acero.",
    "Silver-Plated Mallet - A decorative hammer with silver accents. \n<color=red>Mazo chapado en plata - Un martillo decorativo con detalles de plata.",
    "Artisan's Riveter - A specialized hammer for riveting tasks. \n<color=red>Rivete del artesano - Un martillo especializado para tareas de remachado.",
    "Builder's Bash - A heavy hammer for construction and demolition. \n<color=red>Golpe del constructor - Un martillo pesado para construcción y demolición.",
    "Masonry Maul - A hammer designed for masonry work. \n<color=red>Maza de albañilería - Un martillo diseñado para trabajos de albañilería.",
    "Blacksmith's Basher - A sturdy hammer for blacksmithing tasks. \n<color=red>Paliza del herrero - Un martillo resistente para tareas de herrería.",
    "Miner's Pick - A pickaxe-hammer hybrid for mining operations. \n<color=red>Pico del minero - Una combinación de pico y martillo para operaciones mineras.",
    "Carpenter's Claw - A hammer with a claw for pulling nails. \n<color=red>Garras del carpintero - Un martillo con una garra para sacar clavos.",
    "Journeyman's Mallet - A reliable hammer for seasoned workers. \n<color=red>Mazo del maestro - Un martillo confiable para trabajadores experimentados.",
    "Demolition Dynamo - A powerful hammer for tearing down structures. \n<color=red>Dinamo de demolición - Un martillo potente para derribar estructuras.",
    "Forgemaster's Fury - An intense hammer designed for forging. \n<color=red>Furia del forjador - Un martillo intenso diseñado para forjar.",
    "Battle-Born Bludgeon - A rugged hammer built for combat and construction. \n<color=red>Garrote nacido en la batalla - Un martillo resistente construido para combate y construcción.",
    "Craftsman's Crusher - A crushing hammer for heavy-duty tasks. \n<color=red>Trituradora del artesano - Un martillo aplastante para tareas pesadas.",
    "Ironclad Maul - A powerful maul for breaking through tough materials. \n<color=red>Maza acorazada - Una maza poderosa para romper materiales duros.",
    "Stonebreaker Sledge - A specialized hammer for breaking stone and rock. \n<color=red>Martillo rompepiedras - Un martillo especializado para romper piedra y roca.",
    "Artisan's Anvil - A hammer designed for precision metalwork. \n<color=red>Yunque del artesano - Un martillo diseñado para trabajos de metalurgia de precisión.",
    "Builder's Bane - A heavy hammer for destructive tasks. \n<color=red>Perdición del constructor - Un martillo pesado para tareas destructivas.",
    "Steelstout Sledgehammer - A hefty hammer for tough construction work. \n<color=red>Martillo mazacal de acero - Un martillo robusto para trabajos de construcción difíciles.",
    "Silverstrike Mallet - A mallet with silver accents for precision strikes. \n<color=red>Mazo golpe de plata - Un mazo con detalles de plata para golpes de precisión.",
    "Mason's Maul - A heavy-duty maul for professional masons. \n<color=red>Mazo del albañil - Un mazo resistente para albañiles profesionales.",
    "Forgefire Hammer - A fiery hammer infused with elemental power. \n<color=red>Martillo de fuego forjado - Un martillo ardiente infundido con poder elemental.",
    "Thunderclap Maul - A thunderous maul capable of devastating blows. \n<color=red>Mazo trueno - Un mazo atronador capaz de golpes devastadores.",
    "Celestial Smasher - A divine hammer imbued with celestial energy. \n<color=red>Martillo celestial - Un martillo divino imbuido con energía celestial.",
    "Galactic Hammer - A hammer forged from the stars themselves. \n<color=red>Martillo galáctico - Un martillo forjado de las estrellas mismas.",
    "Ethereal Hammer - A hammer from the realm of spirits, capable of transcending physical barriers. \n<color=red>Martillo etéreo - Un martillo del reino de los espíritus, capaz de trascender barreras físicas."
};





    public string[] hotncold_UPGRADE_textsArray = {
    "Wooden Shovel - A basic shovel made from wood, suitable for light digging tasks. \n<color=red>Pala de madera - Una pala básica hecha de madera, adecuada para tareas de excavación ligeras.",
    "Stone Shovel - An improved shovel crafted from stone, offering better durability and efficiency. \n<color=red>Pala de piedra - Una pala mejorada hecha de piedra, que ofrece mayor durabilidad y eficiencia.",
    "Copper Shovel - A beginner shovel made from copper, slightly better than wood in durability. \n<color=red>Pala de cobre - Una pala básica hecha de cobre, ligeramente mejor que la de madera en durabilidad.",
    "Bronze Shovel - A sturdy shovel made from bronze, capable of handling tougher soil. \n<color=red>Pala de bronce - Una pala resistente hecha de bronce, capaz de manejar suelos más difíciles.",
    "Iron Shovel - A robust shovel forged from iron, suitable for medium-level excavation tasks. \n<color=red>Pala de hierro - Una pala robusta forjada en hierro, adecuada para tareas de excavación de nivel medio.",
    "Steel Shovel - A high-quality shovel made from steel, providing superior strength and longevity. \n<color=red>Pala de acero - Una pala de alta calidad hecha de acero, que proporciona una resistencia y durabilidad superiores.",
    "Silver Shovel - A shovel reinforced with silver, offering enhanced durability and resistance to corrosion. \n<color=red>Pala de plata - Una pala reforzada con plata, que ofrece una durabilidad mejorada y resistencia a la corrosión.",
    "Titanium Shovel - A lightweight yet durable shovel made from titanium, ideal for extended periods of use. \n<color=red>Pala de titanio - Una pala ligera pero duradera hecha de titanio, ideal para períodos de uso prolongado.",
    "Diamond Shovel - An elite shovel adorned with diamond tips, excelling in speed and efficiency for excavation tasks. \n<color=red>Pala de diamante - Una pala de élite adornada con puntas de diamante, sobresaliendo en velocidad y eficiencia para tareas de excavación.",
    "Gold-Plated Shovel - A decorative shovel with a gold-plated surface, offering prestige and style. \n<color=red>Pala chapada en oro - Una pala decorativa con una superficie chapada en oro, que ofrece prestigio y estilo.",
    "Obsidian Shovel - A rare and powerful shovel crafted from obsidian, capable of effortlessly cutting through even the toughest terrain. \n<color=red>Pala de obsidiana - Una pala rara y poderosa hecha de obsidiana, capaz de cortar sin esfuerzo incluso el terreno más duro.",
    "Emerald-Encrusted Shovel - A luxurious shovel adorned with emeralds, offering enhanced durability and style. \n<color=red>Pala incrustada con esmeraldas - Una lujosa pala adornada con esmeraldas, que ofrece una durabilidad mejorada y estilo.",
    "Ruby-Tipped Shovel - A shovel reinforced with ruby tips, providing increased digging power. \n<color=red>Pala con puntas de rubí - Una pala reforzada con puntas de rubí, que proporciona un aumento en la potencia de excavación.",
    "Sapphire-Edged Shovel - A shovel with sapphire edges, offering improved cutting ability. \n<color=red>Pala con bordes de zafiro - Una pala con bordes de zafiro, que ofrece una mejor capacidad de corte.",
    "Amethyst-Handled Shovel - A shovel with amethyst handles, providing enhanced grip and comfort during use. \n<color=red>Pala con mangos de amatista - Una pala con mangos de amatista, que proporciona un agarre mejorado y comodidad durante el uso.",
    "Quartz-Infused Shovel - A shovel infused with quartz crystals, offering increased durability and strength. \n<color=red>Pala infundida con cuarzo - Una pala infundida con cristales de cuarzo, que ofrece una durabilidad y resistencia aumentadas.",
    "Topaz-Plated Shovel - A shovel plated with topaz, offering enhanced digging efficiency. \n<color=red>Pala chapada con topacio - Una pala chapada con topacio, que ofrece una eficiencia de excavación mejorada.",
    "Sapphire-Encrusted Shovel - A shovel encrusted with sapphires, providing increased durability and cutting ability. \n<color=red>Pala incrustada con zafiros - Una pala incrustada con zafiros, que proporciona una durabilidad aumentada y una mejor capacidad de corte.",
    "Ruby-Embossed Shovel - A shovel embossed with rubies, offering superior digging power. \n<color=red>Pala con rubíes grabados - Una pala grabada con rubíes, que ofrece un poder de excavación superior.",
    "Diamond-Plated Shovel - A shovel plated with diamond, providing unmatched durability and digging efficiency. \n<color=red>Pala chapada con diamante - Una pala chapada con diamante, que proporciona una durabilidad y eficiencia de excavación incomparables.",
    "Platinum-Tipped Shovel - A shovel reinforced with platinum tips, offering unparalleled strength and longevity. \n<color=red>Pala con puntas de platino - Una pala reforzada con puntas de platino, que ofrece una fuerza y durabilidad incomparables.",
    "Crystal-Infused Shovel - A shovel infused with magical crystals, offering increased digging power and efficiency. \n<color=red>Pala infundida con cristales mágicos - Una pala infundida con cristales mágicos, que ofrece un aumento en el poder y la eficiencia de excavación.",
    "Enchanted Shovel - A shovel imbued with enchantments, granting it supernatural digging abilities. \n<color=red>Pala encantada - Una pala imbuida con encantamientos, que le otorga habilidades de excavación sobrenaturales.",
    "Adamantium Shovel - A shovel forged from adamantium, known for its indestructibility and unmatched digging power. \n<color=red>Pala de adamantium - Una pala forjada en adamantium, conocida por su indestructibilidad y poder de excavación incomparable.",
    "Darksteel Shovel - A shovel crafted from darksteel, capable of cutting through the toughest of materials with ease. \n<color=red>Pala de acero oscuro - Una pala hecha de acero oscuro, capaz de cortar los materiales más duros con facilidad.",
    "Celestial Shovel - A shovel infused with celestial energy, granting it divine digging abilities. \n<color=red>Pala celestial - Una pala infundida con energía celestial, que le otorga habilidades de excavación divinas.",
    "Galactic Shovel - A shovel forged from the stars themselves, capable of excavating even the most challenging of terrains. \n<color=red>Pala galáctica - Una pala forjada de las estrellas mismas, capaz de excavar incluso los terrenos más desafiantes.",
    "Ethereal Shovel - A shovel from the realm of spirits, capable of digging through both physical and metaphysical barriers. \n<color=red>Pala etérea - Una pala del reino de los espíritus, capaz de excavar tanto barreras físicas como metafísicas.",
    "Legendary Shovel - A shovel of legendary status, said to have been wielded by heroes of old, capable of reshaping the very earth itself. \n<color=red>Pala legendaria - Una pala de estatus legendario, se dice que ha sido empuñada por héroes de antaño, capaz de dar forma a la misma tierra.",
    "Godly Shovel - A shovel blessed by the gods themselves, imbued with divine power and authority over the elements. \n<color=red>Pala divina - Una pala bendecida por los mismos dioses, imbuida de poder divino y autoridad sobre los elementos."
};



    public string[] hotncoldMSG_textsArray = {
    "We need more shovels for digging. \n<color=red>Necesitamos más palas para cavar.",
    "The ground is hard to dig. \n<color=red>El suelo es difícil de cavar.",
    "We've hit a rock while digging. \n<color=red>Hemos golpeado una roca mientras cavábamos.",
    "The hole is too deep. \n<color=red>El agujero es demasiado profundo.",
    "We're running out of space to dump the dirt. \n<color=red>Nos estamos quedando sin espacio para tirar la tierra.",
    "We need to clear the area before digging. \n<color=red>Necesitamos despejar el área antes de cavar.",
    "The shovel broke while digging. \n<color=red>La pala se rompió mientras cavábamos.",
    "We're digging a trench for the foundation. \n<color=red>Estamos cavando una zanja para la base.",
    "The soil is loose and easy to dig. \n<color=red>El suelo está suelto y es fácil de cavar.",
    "We're digging holes for planting trees. \n<color=red>Estamos cavando hoyos para plantar árboles.",
    "The hole is filling with water. \n<color=red>El agujero se está llenando de agua.",
    "We need more workers for digging. \n<color=red>Necesitamos más trabajadores para cavar.",
    "The hole collapsed while digging. \n<color=red>El agujero se derrumbó mientras cavábamos.",
    "We're using a backhoe for digging trenches. \n<color=red>Estamos usando una retroexcavadora para cavar zanjas.",
    "We're digging a pit for the foundation of the building. \n<color=red>Estamos cavando un pozo para la base del edificio.",
    "The hole needs to be wider. \n<color=red>El agujero necesita ser más ancho.",
    "We're digging a hole for a new well. \n<color=red>Estamos cavando un agujero para un pozo nuevo.",
    "We need to dig deeper to find the buried treasure. \n<color=red>Necesitamos cavar más profundo para encontrar el tesoro enterrado.",
    "The hole is filling up with dirt again. \n<color=red>El agujero se está llenando de tierra de nuevo.",
    "We're digging a hole for the fence post. \n<color=red>Estamos cavando un agujero para el poste de la cerca.",
    "The ground is frozen, making it difficult to dig. \n<color=red>El suelo está congelado, lo que hace que sea difícil cavar.",
    "We're using a jackhammer to break through the pavement for digging. \n<color=red>Estamos usando un martillo neumático para romper el pavimento para cavar.",
    "We're digging a hole for a new septic tank. \n<color=red>Estamos cavando un agujero para un nuevo tanque séptico.",
    "The hole is getting deeper with each shovel full of dirt. \n<color=red>El agujero se está haciendo más profundo con cada pala llena de tierra.",
    "We're digging holes for fence posts along the property line. \n<color=red>Estamos cavando agujeros para los postes de la cerca a lo largo de la línea de propiedad.",
    "We need to shore up the walls of the hole to prevent collapse. \n<color=red>Necesitamos apuntalar las paredes del agujero para evitar el derrumbe.",
    "We're digging a hole to bury the old tree stump. \n<color=red>Estamos cavando un agujero para enterrar el viejo tocón de árbol.",
    "The hole is getting wider as we dig. \n<color=red>El agujero se está haciendo más ancho mientras cavamos.",
    "We're digging a hole for a new swimming pool. \n<color=red>Estamos cavando un agujero para una nueva piscina.",
    "The shovel handle snapped while digging. \n<color=red>El mango de la pala se rompió mientras cavábamos.",
    "We're digging a hole for the foundation of the deck. \n<color=red>Estamos cavando un agujero para la base del deck."
};







    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
