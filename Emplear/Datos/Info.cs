using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using  Newtonsoft.Json.Utilities;

namespace Datos
{
  public static class Info
  {
    private static List<Localidad> _localidades;
    private static List<Provincia> _provincias;

    static Info()
    {
      Provincia santaFe = new Provincia() { IDProvincia = "S", Nombre = "Santa Fe" };

      if (Localidades == null)
      {
        Localidades = JsonConvert.DeserializeObject<List<Localidad>>(localidades);
      }

      if (Provincias == null)
      {
        Provincias = new List<Provincia>();
      }
      santaFe.Localidades = new HashSet<Localidad>(Localidades);
      Provincias.Add(santaFe);
      Localidades.ForEach(loc => loc.Provincia = santaFe);
    }

    public static List<Localidad> Localidades { get; private set; }

    public static List<Provincia> Provincias { get; private set; }

    private static string localidades = @"[
      {
        ""IDLocalidad"": 1111,
        ""Nombre"": ""CABEZA DE CHANCHO"",
        ""CodigoPostal"": ""S3061XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1112,
        ""Nombre"": ""CAMPO GARAY"",
        ""CodigoPostal"": ""S3066XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1113,
        ""Nombre"": ""CAMPO SAN JOSE"",
        ""CodigoPostal"": ""S3060XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1114,
        ""Nombre"": ""COLONIA INDEPENDENCIA"",
        ""CodigoPostal"": ""S3066XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1115,
        ""Nombre"": ""COLONIA MONTEFIORE"",
        ""CodigoPostal"": ""S2341XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1116,
        ""Nombre"": ""EL AMARGO"",
        ""CodigoPostal"": ""S3060XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1117,
        ""Nombre"": ""EL MARIANO"",
        ""CodigoPostal"": ""S3060XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1118,
        ""Nombre"": ""EL NOCHERO"",
        ""CodigoPostal"": ""S3061XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1120,
        ""Nombre"": ""ESTEBAN RAMS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1121,
        ""Nombre"": ""FORTIN ALERTA"",
        ""CodigoPostal"": ""S3066XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1122,
        ""Nombre"": ""FORTIN ARGENTINA"",
        ""CodigoPostal"": ""S3060XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1123,
        ""Nombre"": ""FORTIN ATAHUALPA"",
        ""CodigoPostal"": ""S3061XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1124,
        ""Nombre"": ""FORTIN CACIQUE"",
        ""CodigoPostal"": ""S3060XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1125,
        ""Nombre"": ""FORTIN SEIS DE CABALLERIA"",
        ""CodigoPostal"": ""S3061XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1126,
        ""Nombre"": ""FORTIN TOSTADO"",
        ""CodigoPostal"": ""S3060XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1127,
        ""Nombre"": ""GATO COLORADO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1128,
        ""Nombre"": ""GREGORIA PEREZ DE DENIS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1129,
        ""Nombre"": ""INDEPENDENCIA"",
        ""CodigoPostal"": ""S3060XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1130,
        ""Nombre"": ""KILOMETRO 293"",
        ""CodigoPostal"": ""S3066XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1131,
        ""Nombre"": ""KILOMETRO 389"",
        ""CodigoPostal"": ""S3061XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1132,
        ""Nombre"": ""KILOMETRO 421"",
        ""CodigoPostal"": ""S3061XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1133,
        ""Nombre"": ""KILOMETRO 468"",
        ""CodigoPostal"": ""S3061XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1134,
        ""Nombre"": ""LA BOMBILLA"",
        ""CodigoPostal"": ""S3060XAJ"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1135,
        ""Nombre"": ""LA ELSA"",
        ""CodigoPostal"": ""S2341XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1136,
        ""Nombre"": ""LA MARINA"",
        ""CodigoPostal"": ""S2341XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1139,
        ""Nombre"": ""LOS CHARABONES"",
        ""CodigoPostal"": ""S3060XAK"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1140,
        ""Nombre"": ""NUEVA ITALIA"",
        ""CodigoPostal"": ""S3074XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1141,
        ""Nombre"": ""PADRE PEDRO ITURRALDE"",
        ""CodigoPostal"": ""S3061XAJ"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1142,
        ""Nombre"": ""PORTALIS"",
        ""CodigoPostal"": ""S3066XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1143,
        ""Nombre"": ""POZO BORRADO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1144,
        ""Nombre"": ""PUEBLO NUEVO"",
        ""CodigoPostal"": ""S2124XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1145,
        ""Nombre"": ""SANTA MARGARITA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1146,
        ""Nombre"": ""TOSTADO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1147,
        ""Nombre"": ""TRES POZOS"",
        ""CodigoPostal"": ""S3061XAK"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1148,
        ""Nombre"": ""VILLA MINETTI"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1149,
        ""Nombre"": ""ANTONIO PINI"",
        ""CodigoPostal"": ""S3061XAI"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1150,
        ""Nombre"": ""ARMSTRONG"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1151,
        ""Nombre"": ""BOUQUET"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1152,
        ""Nombre"": ""CAMPO CHARO"",
        ""CodigoPostal"": ""S2512XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1153,
        ""Nombre"": ""CAMPO GIMBATTI"",
        ""CodigoPostal"": ""S2508XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1154,
        ""Nombre"": ""CAMPO LA AMISTAD"",
        ""CodigoPostal"": ""S2508XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1155,
        ""Nombre"": ""CAMPO LA PAZ"",
        ""CodigoPostal"": ""S2512XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1156,
        ""Nombre"": ""CAMPO LA RIVIERE"",
        ""CodigoPostal"": ""S2505XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1157,
        ""Nombre"": ""CAMPO SANTA ISABEL"",
        ""CodigoPostal"": ""S2505XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1158,
        ""Nombre"": ""ITURRASPE"",
        ""CodigoPostal"": ""S2523XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1159,
        ""Nombre"": ""LA CALIFORNIA"",
        ""CodigoPostal"": ""S2520XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1160,
        ""Nombre"": ""LAS PAREJAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1161,
        ""Nombre"": ""LAS ROSAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1162,
        ""Nombre"": ""MONTES DE OCA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1163,
        ""Nombre"": ""SAN GUILLERMO"",
        ""CodigoPostal"": ""S2512XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1164,
        ""Nombre"": ""TORTUGAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1165,
        ""Nombre"": ""ARTEAGA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1166,
        ""Nombre"": ""BERABEVU 1"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1167,
        ""Nombre"": ""BIGAND"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1168,
        ""Nombre"": ""CAMPO CRENNA"",
        ""CodigoPostal"": ""S2185XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1169,
        ""Nombre"": ""CAMPO NUEVO"",
        ""CodigoPostal"": ""S2639XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1170,
        ""Nombre"": ""CAMPO PESOA"",
        ""CodigoPostal"": ""S2173XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1171,
        ""Nombre"": ""CANDELARIA SUD"",
        ""CodigoPostal"": ""S2170XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1172,
        ""Nombre"": ""CASILDA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1173,
        ""Nombre"": ""CHABAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1175,
        ""Nombre"": ""COLONIA CANDELARIA"",
        ""CodigoPostal"": ""S2170XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1176,
        ""Nombre"": ""COLONIA FERNANDEZ"",
        ""CodigoPostal"": ""S2639XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1177,
        ""Nombre"": ""COLONIA GOMEZ"",
        ""CodigoPostal"": ""S2639XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1178,
        ""Nombre"": ""COLONIA HANSEN"",
        ""CodigoPostal"": ""S2637XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1179,
        ""Nombre"": ""COLONIA LA  CATALANA"",
        ""CodigoPostal"": ""S2637XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1180,
        ""Nombre"": ""COLONIA LA  PALENCIA"",
        ""CodigoPostal"": ""S2639XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1181,
        ""Nombre"": ""COLONIA LA  PELLEGRINI"",
        ""CodigoPostal"": ""S2639XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1182,
        ""Nombre"": ""COLONIA LA COSTA"",
        ""CodigoPostal"": ""S2170XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1183,
        ""Nombre"": ""COLONIA LAGO DI COMO"",
        ""CodigoPostal"": ""S2187XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1184,
        ""Nombre"": ""COLONIA PIAMONTESA"",
        ""CodigoPostal"": ""S2639XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1185,
        ""Nombre"": ""COLONIA SANTA NATALIA"",
        ""CodigoPostal"": ""S2639XAI"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1186,
        ""Nombre"": ""COLONIA TOSCANA PRIMERA"",
        ""CodigoPostal"": ""S2185XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1187,
        ""Nombre"": ""COLONIA TOSCANA SEGUNDA"",
        ""CodigoPostal"": ""S2185XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1188,
        ""Nombre"": ""COLONIA VALENCIA"",
        ""CodigoPostal"": ""S2639XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1189,
        ""Nombre"": ""CUATRO ESQUINAS"",
        ""CodigoPostal"": ""S2639XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1190,
        ""Nombre"": ""GODEKEN"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1191,
        ""Nombre"": ""LA MERCED"",
        ""CodigoPostal"": ""S2173XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1192,
        ""Nombre"": ""LA VIUDA"",
        ""CodigoPostal"": ""S2183XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1193,
        ""Nombre"": ""LOS MOLINOS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1194,
        ""Nombre"": ""LOS NOGALES"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1195,
        ""Nombre"": ""LOS QUIRQUINCHOS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1196,
        ""Nombre"": ""PUEBLO AREQUITO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1197,
        ""Nombre"": ""SAN JOSE DE LA ESQUINA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1198,
        ""Nombre"": ""SANFORD"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1199,
        ""Nombre"": ""SANTA NATALIA"",
        ""CodigoPostal"": ""S2639XAJ"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1200,
        ""Nombre"": ""VILLADA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1201,
        ""Nombre"": ""ADOLFO ALSINA"",
        ""CodigoPostal"": ""S2311XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1202,
        ""Nombre"": ""ANGELICA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1203,
        ""Nombre"": ""ATALIVA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1206,
        ""Nombre"": ""AURELIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1207,
        ""Nombre"": ""BAUER Y SIGEL"",
        ""CodigoPostal"": ""S2403XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1208,
        ""Nombre"": ""BELLA ITALIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1210,
        ""Nombre"": ""CAMPO CLUCELLAS"",
        ""CodigoPostal"": ""S2407XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1211,
        ""Nombre"": ""CAMPO DARATTI"",
        ""CodigoPostal"": ""S2307XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1212,
        ""Nombre"": ""CAMPO ROMERO"",
        ""CodigoPostal"": ""S2407XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1213,
        ""Nombre"": ""CAMPO TORQUINSTON"",
        ""CodigoPostal"": ""S2403XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1214,
        ""Nombre"": ""CAMPO ZURBRIGGEN"",
        ""CodigoPostal"": ""S2407XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1215,
        ""Nombre"": ""CAPILLA SAN JOSE"",
        ""CodigoPostal"": ""S2301XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1216,
        ""Nombre"": ""CASABLANCA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1217,
        ""Nombre"": ""CLUCELLAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1218,
        ""Nombre"": ""COLONIA ALDAO"",
        ""CodigoPostal"": ""S2317XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1219,
        ""Nombre"": ""COLONIA BELLA ITALIA"",
        ""CodigoPostal"": ""S2300XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1220,
        ""Nombre"": ""COLONIA BICHA"",
        ""CodigoPostal"": ""S2317XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1221,
        ""Nombre"": ""COLONIA BIGAND"",
        ""CodigoPostal"": ""S2317XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1222,
        ""Nombre"": ""COLONIA BOSSI"",
        ""CodigoPostal"": ""S2326XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1223,
        ""Nombre"": ""COLONIA CASTELLANOS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1224,
        ""Nombre"": ""COLONIA CELLO"",
        ""CodigoPostal"": ""S2405XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1225,
        ""Nombre"": ""COLONIA FIDELA"",
        ""CodigoPostal"": ""S2301XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1226,
        ""Nombre"": ""COLONIA JOSEFINA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1227,
        ""Nombre"": ""COLONIA MARGARITA"",
        ""CodigoPostal"": ""S2443XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1228,
        ""Nombre"": ""COLONIA MAUA"",
        ""CodigoPostal"": ""S2311XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1229,
        ""Nombre"": ""COLONIA REINA MARGARITA"",
        ""CodigoPostal"": ""S2309XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1230,
        ""Nombre"": ""COLONIA SAN ANTONIO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1231,
        ""Nombre"": ""COLONIA TACURALES"",
        ""CodigoPostal"": ""S2324XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1232,
        ""Nombre"": ""CONSTANZA"",
        ""CodigoPostal"": ""S2311XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1233,
        ""Nombre"": ""CORONEL FRAGA"",
        ""CodigoPostal"": ""S2301XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1234,
        ""Nombre"": ""CRISTOLIA"",
        ""CodigoPostal"": ""S2445XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1235,
        ""Nombre"": ""DESVIO BOERO"",
        ""CodigoPostal"": ""S2415XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1236,
        ""Nombre"": ""EGUSQUIZA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1237,
        ""Nombre"": ""ESMERALDA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1238,
        ""Nombre"": ""ESTACION CLUCELLAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1239,
        ""Nombre"": ""ESTACION JOSEFINA"",
        ""CodigoPostal"": ""S2403XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1240,
        ""Nombre"": ""ESTACION SAGUIER"",
        ""CodigoPostal"": ""S2315XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1241,
        ""Nombre"": ""ESTRADA"",
        ""CodigoPostal"": ""S2409XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1242,
        ""Nombre"": ""EUSEBIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1243,
        ""Nombre"": ""EUSTOLIA"",
        ""CodigoPostal"": ""S2407XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1244,
        ""Nombre"": ""FRONTERA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1245,
        ""Nombre"": ""GALISTEO"",
        ""CodigoPostal"": ""S2307XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1246,
        ""Nombre"": ""GARIBALDI"",
        ""CodigoPostal"": ""S2443XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1247,
        ""Nombre"": ""HUMBERTO PRIMERO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1248,
        ""Nombre"": ""JOSE MANUEL ESTRADA"",
        ""CodigoPostal"": ""S2403XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1249,
        ""Nombre"": ""KILOMETRO 113"",
        ""CodigoPostal"": ""S2407XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1250,
        ""Nombre"": ""KILOMETRO 483"",
        ""CodigoPostal"": ""S2456XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1251,
        ""Nombre"": ""KILOMETRO 501"",
        ""CodigoPostal"": ""S2409XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1252,
        ""Nombre"": ""KILOMETRO 85"",
        ""CodigoPostal"": ""S2303XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1253,
        ""Nombre"": ""LEHMANN"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1254,
        ""Nombre"": ""LOS SEMBRADOS"",
        ""CodigoPostal"": ""S2447XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1255,
        ""Nombre"": ""MANGORE"",
        ""CodigoPostal"": ""S2445XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1256,
        ""Nombre"": ""MARIA JUANA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1257,
        ""Nombre"": ""MONIGOTES"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1258,
        ""Nombre"": ""PALACIOS"",
        ""CodigoPostal"": ""S2326XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1259,
        ""Nombre"": ""PRESIDENTE ROCA"",
        ""CodigoPostal"": ""S2301XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1260,
        ""Nombre"": ""PUEBLO MARIA JUANA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1261,
        ""Nombre"": ""PUEBLO MARINI"",
        ""CodigoPostal"": ""S2301XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1262,
        ""Nombre"": ""PUEBLO RAMONA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1263,
        ""Nombre"": ""PUEBLO SAN ANTONIO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1264,
        ""Nombre"": ""RAFAELA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1265,
        ""Nombre"": ""RAQUEL"",
        ""CodigoPostal"": ""S2322XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1266,
        ""Nombre"": ""REINA MARGARITA"",
        ""CodigoPostal"": ""S2309XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1267,
        ""Nombre"": ""RINCON DE TACURALES"",
        ""CodigoPostal"": ""S2317XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1268,
        ""Nombre"": ""SAGUIER"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1269,
        ""Nombre"": ""SAN MIGUEL"",
        ""CodigoPostal"": ""S2309XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1270,
        ""Nombre"": ""SAN VICENTE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1271,
        ""Nombre"": ""SANTA CLARA DE SAGUIER"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1272,
        ""Nombre"": ""SUNCHALES"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1273,
        ""Nombre"": ""SUSANA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1274,
        ""Nombre"": ""TACURAL"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1275,
        ""Nombre"": ""VILA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1276,
        ""Nombre"": ""VILLA SAN JOSE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1277,
        ""Nombre"": ""VILLANI"",
        ""CodigoPostal"": ""S2400XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1278,
        ""Nombre"": ""VIRGINIA"",
        ""CodigoPostal"": ""S2311XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1279,
        ""Nombre"": ""ZANETTI"",
        ""CodigoPostal"": ""S2301XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1280,
        ""Nombre"": ""ZENON PEREYRA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1281,
        ""Nombre"": ""CAMPO MAGNIN"",
        ""CodigoPostal"": ""S3011XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1283,
        ""Nombre"": ""CAMPO RODRIGUEZ"",
        ""CodigoPostal"": ""S2255XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1284,
        ""Nombre"": ""CAVOUR"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1285,
        ""Nombre"": ""COLONIA ADOLFO ALSINA"",
        ""CodigoPostal"": ""S3029XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1286,
        ""Nombre"": ""COLONIA LA NUEVA"",
        ""CodigoPostal"": ""S3081XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1287,
        ""Nombre"": ""COLONIA MATILDE"",
        ""CodigoPostal"": ""S3013XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1288,
        ""Nombre"": ""COLONIA PUJOL"",
        ""CodigoPostal"": ""S3080XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1289,
        ""Nombre"": ""CORONEL RODRIGUEZ"",
        ""CodigoPostal"": ""S3013XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1290,
        ""Nombre"": ""CULULU"",
        ""CodigoPostal"": ""S3023XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1291,
        ""Nombre"": ""DESVIO ARAUZ"",
        ""CodigoPostal"": ""S3029XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1292,
        ""Nombre"": ""EL TROPEZON"",
        ""CodigoPostal"": ""S3009XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1293,
        ""Nombre"": ""ELISA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1294,
        ""Nombre"": ""EMPALME SAN CARLOS"",
        ""CodigoPostal"": ""S3007XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1295,
        ""Nombre"": ""ESPERANZA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1296,
        ""Nombre"": ""ESTACION MATILDE"",
        ""CodigoPostal"": ""S3013XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1297,
        ""Nombre"": ""FELICIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1298,
        ""Nombre"": ""FRANCK"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1299,
        ""Nombre"": ""GRUTLY"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1300,
        ""Nombre"": ""GRUTLY NORTE"",
        ""CodigoPostal"": ""S3083XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1301,
        ""Nombre"": ""HIPATIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1302,
        ""Nombre"": ""HUMBOLDT"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1303,
        ""Nombre"": ""HUMBOLDT CHICO"",
        ""CodigoPostal"": ""S3081XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1304,
        ""Nombre"": ""ITUZAINGO"",
        ""CodigoPostal"": ""S2311XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1305,
        ""Nombre"": ""LA ORILLA"",
        ""CodigoPostal"": ""S3080XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1306,
        ""Nombre"": ""LA PELADA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1307,
        ""Nombre"": ""LARRECHEA"",
        ""CodigoPostal"": ""S3080XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1308,
        ""Nombre"": ""LAS HIGUERITAS"",
        ""CodigoPostal"": ""S3013XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1309,
        ""Nombre"": ""LAS TUNAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1310,
        ""Nombre"": ""MARIA LUISA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1311,
        ""Nombre"": ""MARIANO SAAVEDRA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1312,
        ""Nombre"": ""NUEVO TORINO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1313,
        ""Nombre"": ""PERICOTA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1314,
        ""Nombre"": ""PILAR"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1315,
        ""Nombre"": ""PROGRESO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1316,
        ""Nombre"": ""PROVIDENCIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1317,
        ""Nombre"": ""PUEBLO ABC"",
        ""CodigoPostal"": ""S3080XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1318,
        ""Nombre"": ""PUJATO NORTE"",
        ""CodigoPostal"": ""S3080XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1319,
        ""Nombre"": ""RINCON DEL PINTADO"",
        ""CodigoPostal"": ""S3080XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1320,
        ""Nombre"": ""RIVADAVIA"",
        ""CodigoPostal"": ""S3081XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1321,
        ""Nombre"": ""SA PEREYRA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1322,
        ""Nombre"": ""SAN AGUSTIN"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1323,
        ""Nombre"": ""SAN CARLOS CENTRO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1324,
        ""Nombre"": ""SAN CARLOS NORTE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1325,
        ""Nombre"": ""SAN CARLOS SUD"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1326,
        ""Nombre"": ""SAN JERONIMO DEL SAUCE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1327,
        ""Nombre"": ""SAN JERONIMO NORTE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1328,
        ""Nombre"": ""SAN MARIANO"",
        ""CodigoPostal"": ""S3011XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1329,
        ""Nombre"": ""SANTA CLARA DE BUENA VISTA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1330,
        ""Nombre"": ""SANTA MARIA"",
        ""CodigoPostal"": ""S3011XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1331,
        ""Nombre"": ""SANTO DOMINGO"",
        ""CodigoPostal"": ""S3025XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1332,
        ""Nombre"": ""SARMIENTO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1333,
        ""Nombre"": ""TOMAS ALVA EDISON"",
        ""CodigoPostal"": ""S3023XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1334,
        ""Nombre"": ""BOMBAL"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1335,
        ""Nombre"": ""CAMPO RUEDA"",
        ""CodigoPostal"": ""S2109XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1337,
        ""Nombre"": ""CEPEDA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1338,
        ""Nombre"": ""COLONIA VALDEZ"",
        ""CodigoPostal"": ""S2115XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1339,
        ""Nombre"": ""EL BAGUAL"",
        ""CodigoPostal"": ""S2723XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1340,
        ""Nombre"": ""EMPALME VILLA CONSTITUCION"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1341,
        ""Nombre"": ""ESTACION VILLA CONSTITUCION"",
        ""CodigoPostal"": ""S2919XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1342,
        ""Nombre"": ""FRANCISCO PAZ"",
        ""CodigoPostal"": ""S2111XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1343,
        ""Nombre"": ""GENERAL GELLY"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1344,
        ""Nombre"": ""GODOY"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1345,
        ""Nombre"": ""JUAN B MOLINA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1346,
        ""Nombre"": ""JUNCAL"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1347,
        ""Nombre"": ""LA OTHILA"",
        ""CodigoPostal"": ""S2115XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1348,
        ""Nombre"": ""LA VANGUARDIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1349,
        ""Nombre"": ""LOMA VERDE"",
        ""CodigoPostal"": ""S2117XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1350,
        ""Nombre"": ""MAXIMO PAZ"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1351,
        ""Nombre"": ""ORATORIO MORANTE"",
        ""CodigoPostal"": ""S2921XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1352,
        ""Nombre"": ""PAVON"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1353,
        ""Nombre"": ""PAVON ARRIBA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1354,
        ""Nombre"": ""PEYRANO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1355,
        ""Nombre"": ""PUEBLO ALCORTA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1356,
        ""Nombre"": ""RODOLFO ALCORTA"",
        ""CodigoPostal"": ""S2115XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1357,
        ""Nombre"": ""RUEDA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1358,
        ""Nombre"": ""SANTA TERESA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1359,
        ""Nombre"": ""SARGENTO CABRAL"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1360,
        ""Nombre"": ""STEPHENSON"",
        ""CodigoPostal"": ""S2103XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1361,
        ""Nombre"": ""THEOBALD"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1362,
        ""Nombre"": ""TRES ESQUINAS"",
        ""CodigoPostal"": ""S2921XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1363,
        ""Nombre"": ""VILLA CONSTITUCION"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1364,
        ""Nombre"": ""LA CELIA"",
        ""CodigoPostal"": ""S2115XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1366,
        ""Nombre"": ""AGUARA GRANDE"",
        ""CodigoPostal"": ""S3071XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1367,
        ""Nombre"": ""AMBROSETTI"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1368,
        ""Nombre"": ""BEALISTOCK"",
        ""CodigoPostal"": ""S2326XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1369,
        ""Nombre"": ""CAMPO BOTTO"",
        ""CodigoPostal"": ""S2345XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1370,
        ""Nombre"": ""CAMPO EL MATACO"",
        ""CodigoPostal"": ""S2342XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1371,
        ""Nombre"": ""CAPIVARA"",
        ""CodigoPostal"": ""S2311XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1372,
        ""Nombre"": ""CERES"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1373,
        ""Nombre"": ""COLONIA ANA"",
        ""CodigoPostal"": ""S2345XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1374,
        ""Nombre"": ""COLONIA BERLIN"",
        ""CodigoPostal"": ""S2313XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1375,
        ""Nombre"": ""COLONIA CLARA"",
        ""CodigoPostal"": ""S3025XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1376,
        ""Nombre"": ""COLONIA EL SIMBOL"",
        ""CodigoPostal"": ""S3074XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1377,
        ""Nombre"": ""COLONIA MACKINLAY"",
        ""CodigoPostal"": ""S2347XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1378,
        ""Nombre"": ""COLONIA MALHMAN SUD"",
        ""CodigoPostal"": ""S2347XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1379,
        ""Nombre"": ""COLONIA ORTIZ"",
        ""CodigoPostal"": ""S2313XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1380,
        ""Nombre"": ""COLONIA RIPAMONTI"",
        ""CodigoPostal"": ""S2349XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1381,
        ""Nombre"": ""COLONIA ROSA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1382,
        ""Nombre"": ""CUATRO CASAS"",
        ""CodigoPostal"": ""S2313XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1383,
        ""Nombre"": ""CURUPAITY"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1384,
        ""Nombre"": ""DOCE CASAS"",
        ""CodigoPostal"": ""S2313XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1385,
        ""Nombre"": ""EL AGUARA"",
        ""CodigoPostal"": ""S3070XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1386,
        ""Nombre"": ""HERSILIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1387,
        ""Nombre"": ""HUANQUEROS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1388,
        ""Nombre"": ""HUGENTOBLER"",
        ""CodigoPostal"": ""S2344XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1389,
        ""Nombre"": ""KILOMETRO 235"",
        ""CodigoPostal"": ""S3076XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1390,
        ""Nombre"": ""LA CABRAL"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1391,
        ""Nombre"": ""LA CLARA"",
        ""CodigoPostal"": ""S3025XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1392,
        ""Nombre"": ""LA LUCILA"",
        ""CodigoPostal"": ""S3072XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1393,
        ""Nombre"": ""LA POLVAREDA"",
        ""CodigoPostal"": ""S3074XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1394,
        ""Nombre"": ""LA RUBIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1395,
        ""Nombre"": ""LA VERDE"",
        ""CodigoPostal"": ""S3076XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1396,
        ""Nombre"": ""LAGUNA VERDE"",
        ""CodigoPostal"": ""S3076XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1397,
        ""Nombre"": ""LAS AVISPAS"",
        ""CodigoPostal"": ""S3074XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1398,
        ""Nombre"": ""LAS PALMERAS"",
        ""CodigoPostal"": ""S2326XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1399,
        ""Nombre"": ""LOS MOLLES"",
        ""CodigoPostal"": ""S3070XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1400,
        ""Nombre"": ""MARIA EUGENIA"",
        ""CodigoPostal"": ""S3072XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1401,
        ""Nombre"": ""MOISES VILLE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1402,
        ""Nombre"": ""MONTE OBSCURIDAD"",
        ""CodigoPostal"": ""S2349XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1403,
        ""Nombre"": ""MUTCHNIK"",
        ""CodigoPostal"": ""S2313XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1404,
        ""Nombre"": ""PETRONILA"",
        ""CodigoPostal"": ""S3046XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1405,
        ""Nombre"": ""PORTUGALETE"",
        ""CodigoPostal"": ""S3071XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1406,
        ""Nombre"": ""RINCON DE SAN ANTONIO"",
        ""CodigoPostal"": ""S3046XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1407,
        ""Nombre"": ""RINCON DEL QUEBRACHO"",
        ""CodigoPostal"": ""S3025XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1408,
        ""Nombre"": ""SAN CRISTOBAL"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1409,
        ""Nombre"": ""SAN GUILLERMO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1410,
        ""Nombre"": ""SANTURCE"",
        ""CodigoPostal"": ""S3074XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1411,
        ""Nombre"": ""SUARDI"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1412,
        ""Nombre"": ""VEINTICUATRO CASAS"",
        ""CodigoPostal"": ""S2313XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1413,
        ""Nombre"": ""VILLA SARALEGUI"",
        ""CodigoPostal"": ""S3046XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1414,
        ""Nombre"": ""VILLA TRINIDAD"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1415,
        ""Nombre"": ""WALVELBERG"",
        ""CodigoPostal"": ""S2313XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1416,
        ""Nombre"": ""ZADOCKHAN"",
        ""CodigoPostal"": ""S2326XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1417,
        ""Nombre"": ""CALCHINES"",
        ""CodigoPostal"": ""S3001XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1418,
        ""Nombre"": ""CAMPO DEL MEDIO"",
        ""CodigoPostal"": ""S3001XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1419,
        ""Nombre"": ""CAMPO ITURRASPE"",
        ""CodigoPostal"": ""S3001XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1420,
        ""Nombre"": ""CAYASTA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1421,
        ""Nombre"": ""COLONIA CALIFORNIA"",
        ""CodigoPostal"": ""S3005XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1422,
        ""Nombre"": ""COLONIA NUEVA NARCISO"",
        ""CodigoPostal"": ""S3001XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1423,
        ""Nombre"": ""COLONIA SAN JOAQUIN"",
        ""CodigoPostal"": ""S3001XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1424,
        ""Nombre"": ""EL LAUREL"",
        ""CodigoPostal"": ""S3001XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1425,
        ""Nombre"": ""EL POZO"",
        ""CodigoPostal"": ""S3001XAI"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1426,
        ""Nombre"": ""HELVECIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1427,
        ""Nombre"": ""JOSE MACIAS"",
        ""CodigoPostal"": ""S3041XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1428,
        ""Nombre"": ""LA NORIA"",
        ""CodigoPostal"": ""S3001XAJ"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1430,
        ""Nombre"": ""LAS TRES MARIAS"",
        ""CodigoPostal"": ""S3046XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1431,
        ""Nombre"": ""LOS CERRILLOS"",
        ""CodigoPostal"": ""S3001XAK"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1432,
        ""Nombre"": ""RECREO SUR"",
        ""CodigoPostal"": ""S3001XAL"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1433,
        ""Nombre"": ""RUINAS SANTA FE LA VIEJA"",
        ""CodigoPostal"": ""S3001XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1434,
        ""Nombre"": ""SALADERO M CABAL"",
        ""CodigoPostal"": ""S3001XAX"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1435,
        ""Nombre"": ""SAN JOAQUIN"",
        ""CodigoPostal"": ""S3001XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1436,
        ""Nombre"": ""SANTA ROSA DE CALCHINES"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1437,
        ""Nombre"": ""VUELTA DEL PIRATA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1438,
        ""Nombre"": ""ANDINO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1439,
        ""Nombre"": ""BERRETTA"",
        ""CodigoPostal"": ""S2501XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1440,
        ""Nombre"": ""BUSTINZA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1441,
        ""Nombre"": ""CAMPO HORQUESCO"",
        ""CodigoPostal"": ""S2144XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1442,
        ""Nombre"": ""CAMPO MEDINA"",
        ""CodigoPostal"": ""S2142XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1443,
        ""Nombre"": ""CAMPO PALETTA"",
        ""CodigoPostal"": ""S2206XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1444,
        ""Nombre"": ""CAMPO RAFFO"",
        ""CodigoPostal"": ""S2216XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1446,
        ""Nombre"": ""CARRIZALES"",
        ""CodigoPostal"": ""S2218XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1447,
        ""Nombre"": ""CLARKE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1448,
        ""Nombre"": ""CLASON"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1449,
        ""Nombre"": ""COLONIA MEDICI"",
        ""CodigoPostal"": ""S2144XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1450,
        ""Nombre"": ""COLONIA TRES MARIAS"",
        ""CodigoPostal"": ""S2216XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1451,
        ""Nombre"": ""CORREA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1452,
        ""Nombre"": ""GRANJA SAN MANUEL"",
        ""CodigoPostal"": ""S2501XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1453,
        ""Nombre"": ""KILOMETRO 323"",
        ""CodigoPostal"": ""S2142XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1454,
        ""Nombre"": ""KILOMETRO 49"",
        ""CodigoPostal"": ""S2506XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1455,
        ""Nombre"": ""LARGUIA"",
        ""CodigoPostal"": ""S2144XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1456,
        ""Nombre"": ""LOS LEONES"",
        ""CodigoPostal"": ""S2146XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1457,
        ""Nombre"": ""LUCIO V LOPEZ"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1458,
        ""Nombre"": ""MARIA LUISA CORREA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1459,
        ""Nombre"": ""OLIVEROS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1460,
        ""Nombre"": ""RINCON DE GRONDONA"",
        ""CodigoPostal"": ""S2206XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1461,
        ""Nombre"": ""SALTO GRANDE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1462,
        ""Nombre"": ""SAN ESTANISLAO"",
        ""CodigoPostal"": ""S2501XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1464,
        ""Nombre"": ""SAN RICARDO"",
        ""CodigoPostal"": ""S2501XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1465,
        ""Nombre"": ""SERODINO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1466,
        ""Nombre"": ""TOTORAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1467,
        ""Nombre"": ""VILLA ELOISA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1468,
        ""Nombre"": ""CAMPO HUBER"",
        ""CodigoPostal"": ""S3555XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1469,
        ""Nombre"": ""CAMPO ZAVALLA"",
        ""CodigoPostal"": ""S3045XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1470,
        ""Nombre"": ""ARIJON"",
        ""CodigoPostal"": ""S2242XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1471,
        ""Nombre"": ""AROCENA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1472,
        ""Nombre"": ""BARRANCAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1473,
        ""Nombre"": ""BARRIO CAIMA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1474,
        ""Nombre"": ""BERNARDO DE IRIGOYEN"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1475,
        ""Nombre"": ""CAMPO BRARDA"",
        ""CodigoPostal"": ""S2248XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1476,
        ""Nombre"": ""CAMPO CARIGNANO"",
        ""CodigoPostal"": ""S2248XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1477,
        ""Nombre"": ""CAMPO GALLOSO"",
        ""CodigoPostal"": ""S2212XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1478,
        ""Nombre"": ""CAMPO GARCIA"",
        ""CodigoPostal"": ""S2240XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1479,
        ""Nombre"": ""CAMPO GENERO"",
        ""CodigoPostal"": ""S2248XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1480,
        ""Nombre"": ""CAMPO GIMENEZ"",
        ""CodigoPostal"": ""S2253XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1481,
        ""Nombre"": ""CAMPO MOURE"",
        ""CodigoPostal"": ""S2240XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1482,
        ""Nombre"": ""CARCEL MODELO CORONDA"",
        ""CodigoPostal"": ""S2240XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1483,
        ""Nombre"": ""CENTENO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1484,
        ""Nombre"": ""COLONIA CORONDINA"",
        ""CodigoPostal"": ""S2240XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1485,
        ""Nombre"": ""COLONIA PIAGGIO"",
        ""CodigoPostal"": ""S2252XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1486,
        ""Nombre"": ""CORONDA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1487,
        ""Nombre"": ""DESVIO ARIJON"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1488,
        ""Nombre"": ""DIAZ"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1489,
        ""Nombre"": ""GABOTO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1490,
        ""Nombre"": ""GESSLER"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1491,
        ""Nombre"": ""IRIGOYEN"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1492,
        ""Nombre"": ""LARRECHEA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1493,
        ""Nombre"": ""LOMA ALTA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1494,
        ""Nombre"": ""LOPEZ"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1495,
        ""Nombre"": ""MACIEL"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1496,
        ""Nombre"": ""MONJE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1498,
        ""Nombre"": ""PUENTE COLASTINE"",
        ""CodigoPostal"": ""S2242XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1499,
        ""Nombre"": ""PUERTO ARAGON"",
        ""CodigoPostal"": ""S2246XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1500,
        ""Nombre"": ""PUERTO GABOTO"",
        ""CodigoPostal"": ""S2208XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1501,
        ""Nombre"": ""RIGBY"",
        ""CodigoPostal"": ""S2255XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1502,
        ""Nombre"": ""SAN FABIAN"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1503,
        ""Nombre"": ""SAN GENARO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1504,
        ""Nombre"": ""SAN GENARO NORTE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1505,
        ""Nombre"": ""VILLA BIOTA"",
        ""CodigoPostal"": ""S2147XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1506,
        ""Nombre"": ""VILLA GUASTALLA"",
        ""CodigoPostal"": ""S2148XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1507,
        ""Nombre"": ""FORTIN ALMAGRO"",
        ""CodigoPostal"": ""S3040XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1508,
        ""Nombre"": ""ALTO VERDE"",
        ""CodigoPostal"": ""S3001XAM"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1509,
        ""Nombre"": ""ANGEL GALLARDO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1510,
        ""Nombre"": ""AROMOS"",
        ""CodigoPostal"": ""S3036XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1511,
        ""Nombre"": ""ARROYO AGUIAR"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1512,
        ""Nombre"": ""ARROYO LEYES"",
        ""CodigoPostal"": ""S3001XAP"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1513,
        ""Nombre"": ""ASCOCHINGAS"",
        ""CodigoPostal"": ""S3014XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1514,
        ""Nombre"": ""BAJO LAS TUNAS"",
        ""CodigoPostal"": ""S3017XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1515,
        ""Nombre"": ""BARRANQUITAS"",
        ""CodigoPostal"": ""S3000XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1516,
        ""Nombre"": ""CABAL"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1517,
        ""Nombre"": ""CAMPO ANDINO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1518,
        ""Nombre"": ""CAMPO CRESPO"",
        ""CodigoPostal"": ""S3001XAQ"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1519,
        ""Nombre"": ""CAMPO LEHMAN"",
        ""CodigoPostal"": ""S3014XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1520,
        ""Nombre"": ""CAMPO SANTO DOMINGO"",
        ""CodigoPostal"": ""S3020XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1521,
        ""Nombre"": ""CANDIOTI"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1522,
        ""Nombre"": ""COLASTINE"",
        ""CodigoPostal"": ""S3001XAN"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1523,
        ""Nombre"": ""COLASTINE NORTE"",
        ""CodigoPostal"": ""S3001XAO"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1524,
        ""Nombre"": ""COLONIA CAMPO BOTTO"",
        ""CodigoPostal"": ""S3036XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1525,
        ""Nombre"": ""CONSTITUYENTES"",
        ""CodigoPostal"": ""S3014XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1526,
        ""Nombre"": ""EL GALPON"",
        ""CodigoPostal"": ""S3021XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1527,
        ""Nombre"": ""EMILIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1528,
        ""Nombre"": ""IRIONDO"",
        ""CodigoPostal"": ""S3018XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1530,
        ""Nombre"": ""KILOMETRO 28"",
        ""CodigoPostal"": ""S3014XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1531,
        ""Nombre"": ""KILOMETRO 35"",
        ""CodigoPostal"": ""S3014XAI"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1532,
        ""Nombre"": ""KILOMETRO 41"",
        ""CodigoPostal"": ""S3020XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1533,
        ""Nombre"": ""KILOMETRO 49"",
        ""CodigoPostal"": ""S3023XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1534,
        ""Nombre"": ""KILOMETRO 9"",
        ""CodigoPostal"": ""S3000XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1535,
        ""Nombre"": ""LA GUARDIA"",
        ""CodigoPostal"": ""S3001XAS"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1536,
        ""Nombre"": ""LAGUNA PAIVA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1537,
        ""Nombre"": ""LASSAGA"",
        ""CodigoPostal"": ""S3036XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1538,
        ""Nombre"": ""LLAMBI CAMPBELL"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1539,
        ""Nombre"": ""LOS HORNOS"",
        ""CodigoPostal"": ""S3021XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1540,
        ""Nombre"": ""MANUCHO"",
        ""CodigoPostal"": ""S3023XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1541,
        ""Nombre"": ""MONTE VERA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1542,
        ""Nombre"": ""NELSON"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1543,
        ""Nombre"": ""NUEVA POMPEYA"",
        ""CodigoPostal"": ""S3014XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1544,
        ""Nombre"": ""PASO VINAL"",
        ""CodigoPostal"": ""S3080XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1545,
        ""Nombre"": ""PIQUETE"",
        ""CodigoPostal"": ""S3000XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1546,
        ""Nombre"": ""POMPEYA"",
        ""CodigoPostal"": ""S3014XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1547,
        ""Nombre"": ""PUEBLO CANDIOTI"",
        ""CodigoPostal"": ""S3000XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1548,
        ""Nombre"": ""RECREO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1549,
        ""Nombre"": ""REYNALDO CULLEN"",
        ""CodigoPostal"": ""S3020XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1550,
        ""Nombre"": ""RINCON NORTE"",
        ""CodigoPostal"": ""S3001XAT"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1551,
        ""Nombre"": ""RINCON POTREROS"",
        ""CodigoPostal"": ""S3001XAU"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1552,
        ""Nombre"": ""RINLON DE AVILA"",
        ""CodigoPostal"": ""S3023XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1553,
        ""Nombre"": ""RIO SALADO"",
        ""CodigoPostal"": ""S3036XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1554,
        ""Nombre"": ""SAN GUILLERMO"",
        ""CodigoPostal"": ""S3020XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1555,
        ""Nombre"": ""SAN JOSE"",
        ""CodigoPostal"": ""S3000XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1556,
        ""Nombre"": ""SAN JOSE DEL RINCON"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1557,
        ""Nombre"": ""SAN PEDRO"",
        ""CodigoPostal"": ""S3021XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1558,
        ""Nombre"": ""SAN PEDRO NORTE"",
        ""CodigoPostal"": ""S3021XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1559,
        ""Nombre"": ""SAN PEDRO SUR"",
        ""CodigoPostal"": ""S3014XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1864,
        ""Nombre"": ""SANTO TOME"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1865,
        ""Nombre"": ""SAUCE VIEJO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1866,
        ""Nombre"": ""SETUBAL"",
        ""CodigoPostal"": ""S3014XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1867,
        ""Nombre"": ""VILLA DON BOSCO"",
        ""CodigoPostal"": ""S3000XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1868,
        ""Nombre"": ""VILLA LUJAN"",
        ""CodigoPostal"": ""S3016XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1869,
        ""Nombre"": ""VILLA MARIA SELVA"",
        ""CodigoPostal"": ""S3000XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1870,
        ""Nombre"": ""VILLA VIVEROS"",
        ""CodigoPostal"": ""S3001XAV"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1871,
        ""Nombre"": ""VILLA YAPEYU"",
        ""CodigoPostal"": ""S3000XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1872,
        ""Nombre"": ""YAMANDU"",
        ""CodigoPostal"": ""S3014XAJ"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1873,
        ""Nombre"": ""INGENIERO BOASI"",
        ""CodigoPostal"": ""S3023XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1874,
        ""Nombre"": ""SANTA CLARA"",
        ""CodigoPostal"": ""S2258XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1875,
        ""Nombre"": ""ARON CASTELLANOS"",
        ""CodigoPostal"": ""S6106XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1876,
        ""Nombre"": ""AMENABAR"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1877,
        ""Nombre"": ""CAFFERATA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1878,
        ""Nombre"": ""CAMINERA GENERAL LOPEZ"",
        ""CodigoPostal"": ""S2720XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1879,
        ""Nombre"": ""CAMPO QUIRNO"",
        ""CodigoPostal"": ""S2607XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1881,
        ""Nombre"": ""CARLOS DOSE"",
        ""CodigoPostal"": ""S2635XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1882,
        ""Nombre"": ""CARMEN"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1883,
        ""Nombre"": ""CARRERAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1884,
        ""Nombre"": ""CHAPUY"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1885,
        ""Nombre"": ""CHOVET"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1886,
        ""Nombre"": ""CORONEL ROSETI"",
        ""CodigoPostal"": ""S6106XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1887,
        ""Nombre"": ""COLONIA MORGAN"",
        ""CodigoPostal"": ""S2609XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1888,
        ""Nombre"": ""COLONIA SANTA LUCIA"",
        ""CodigoPostal"": ""S2609XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1889,
        ""Nombre"": ""CORA"",
        ""CodigoPostal"": ""S2631XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1890,
        ""Nombre"": ""4 DE FEBRERO"",
        ""CodigoPostal"": ""S2732XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1891,
        ""Nombre"": ""DIEGO DE ALVEAR"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1892,
        ""Nombre"": ""DURHAM"",
        ""CodigoPostal"": ""S2631XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1893,
        ""Nombre"": ""EL ALBERDON"",
        ""CodigoPostal"": ""S6106XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1894,
        ""Nombre"": ""EL CANTOR"",
        ""CodigoPostal"": ""S2643XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1895,
        ""Nombre"": ""EL JARDIN"",
        ""CodigoPostal"": ""S2732XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1896,
        ""Nombre"": ""EL REFUGIO"",
        ""CodigoPostal"": ""S6103XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1897,
        ""Nombre"": ""ELORTONDO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1898,
        ""Nombre"": ""ENCADENADAS"",
        ""CodigoPostal"": ""S2607XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1899,
        ""Nombre"": ""ESTACION CHRISTOPHERSEN"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1900,
        ""Nombre"": ""FIRMAT"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1901,
        ""Nombre"": ""HUGHES"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1902,
        ""Nombre"": ""KILOMETRO 396"",
        ""CodigoPostal"": ""S6106XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1903,
        ""Nombre"": ""LA ADELAIDA"",
        ""CodigoPostal"": ""S6103XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1904,
        ""Nombre"": ""LA ASTURIANA"",
        ""CodigoPostal"": ""S6106XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1905,
        ""Nombre"": ""LA CALMA"",
        ""CodigoPostal"": ""S6106XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1906,
        ""Nombre"": ""LA CHISPA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1907,
        ""Nombre"": ""LA CONSTANCIA"",
        ""CodigoPostal"": ""S6103XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1908,
        ""Nombre"": ""LA GAMA"",
        ""CodigoPostal"": ""S2615XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1909,
        ""Nombre"": ""LA INES"",
        ""CodigoPostal"": ""S6100XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1910,
        ""Nombre"": ""LA INGLESITA"",
        ""CodigoPostal"": ""S2601XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1911,
        ""Nombre"": ""LA MOROCHA"",
        ""CodigoPostal"": ""S2613XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1912,
        ""Nombre"": ""LA PICASA"",
        ""CodigoPostal"": ""S6036XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1913,
        ""Nombre"": ""LABORDEBOY"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1914,
        ""Nombre"": ""LAS DOS ANGELITAS"",
        ""CodigoPostal"": ""S6106XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1915,
        ""Nombre"": ""LAS ENCADENADAS"",
        ""CodigoPostal"": ""S2607XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1916,
        ""Nombre"": ""LAZZARINO"",
        ""CodigoPostal"": ""S6103XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1917,
        ""Nombre"": ""LOS ARCOS"",
        ""CodigoPostal"": ""S2720XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1918,
        ""Nombre"": ""MAGGIOLO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1919,
        ""Nombre"": ""MARIA TERESA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1920,
        ""Nombre"": ""MELINCUE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1921,
        ""Nombre"": ""MERCEDITAS"",
        ""CodigoPostal"": ""S2725XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1922,
        ""Nombre"": ""MIRAMAR"",
        ""CodigoPostal"": ""S6106XAI"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1923,
        ""Nombre"": ""MURPHY"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1924,
        ""Nombre"": ""OTTO BEMBERG"",
        ""CodigoPostal"": ""S2605XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1925,
        ""Nombre"": ""PUEBLO MIGUEL TORRES"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1926,
        ""Nombre"": ""RASTREADOR FOURNIER"",
        ""CodigoPostal"": ""S2605XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1927,
        ""Nombre"": ""RUFINO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1928,
        ""Nombre"": ""RUNCIMAN"",
        ""CodigoPostal"": ""S2611XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1929,
        ""Nombre"": ""SAN CARLOS"",
        ""CodigoPostal"": ""S6106XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1930,
        ""Nombre"": ""SAN EDUARDO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1931,
        ""Nombre"": ""SAN FRANCISCO DE SANTA FE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1932,
        ""Nombre"": ""SAN GREGORIO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1933,
        ""Nombre"": ""SAN MARCELO"",
        ""CodigoPostal"": ""S6009XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1934,
        ""Nombre"": ""SAN MARCOS DE VENADO TUERTO"",
        ""CodigoPostal"": ""S2600XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1935,
        ""Nombre"": ""SAN URBANO"",
        ""CodigoPostal"": ""S2728XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1936,
        ""Nombre"": ""SANCTI SPIRITU"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1937,
        ""Nombre"": ""SANTA EMILIA"",
        ""CodigoPostal"": ""S2725XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1938,
        ""Nombre"": ""SANTA ISABEL"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1939,
        ""Nombre"": ""SANTA PAULA"",
        ""CodigoPostal"": ""S6106XAJ"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1940,
        ""Nombre"": ""TARRAGONA"",
        ""CodigoPostal"": ""S6103XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1941,
        ""Nombre"": ""TEODELINA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1942,
        ""Nombre"": ""VENADO TUERTO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1944,
        ""Nombre"": ""VILLA DIVISA DE MAYO"",
        ""CodigoPostal"": ""S2631XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1945,
        ""Nombre"": ""VILLA FREDICKSON"",
        ""CodigoPostal"": ""S2630XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1946,
        ""Nombre"": ""VILLA REGULES"",
        ""CodigoPostal"": ""S2630XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1947,
        ""Nombre"": ""VILLA ROSELLO"",
        ""CodigoPostal"": ""S6100XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1948,
        ""Nombre"": ""WHEELWRIGHT"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1949,
        ""Nombre"": ""ARROYO CEIBAL"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1950,
        ""Nombre"": ""ARROYO DEL REY"",
        ""CodigoPostal"": ""S3565XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1951,
        ""Nombre"": ""AVELLANEDA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1952,
        ""Nombre"": ""BERNA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1953,
        ""Nombre"": ""CAMPO EL ARAZA"",
        ""CodigoPostal"": ""S3569XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1954,
        ""Nombre"": ""CAMPO FURRER"",
        ""CodigoPostal"": ""S3569XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1955,
        ""Nombre"": ""CAMPO GARABATO"",
        ""CodigoPostal"": ""S3572XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1956,
        ""Nombre"": ""CAMPO GOLA"",
        ""CodigoPostal"": ""S3516XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1957,
        ""Nombre"": ""CAMPO GRANDE"",
        ""CodigoPostal"": ""S3575XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1958,
        ""Nombre"": ""CAMPO HARDY"",
        ""CodigoPostal"": ""S3592XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1959,
        ""Nombre"": ""CAMPO RAMSEYER"",
        ""CodigoPostal"": ""S3572XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1960,
        ""Nombre"": ""CAMPO REDONDO"",
        ""CodigoPostal"": ""S3581XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1961,
        ""Nombre"": ""CAMPO SIETE PROVINCIAS"",
        ""CodigoPostal"": ""S3575XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1962,
        ""Nombre"": ""CAMPO URDANIZ"",
        ""CodigoPostal"": ""S3516XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1963,
        ""Nombre"": ""CAMPO VERGE"",
        ""CodigoPostal"": ""S3516XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1964,
        ""Nombre"": ""CAMPO YAGUARETE"",
        ""CodigoPostal"": ""S3586XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1965,
        ""Nombre"": ""CAPILLA GUADALUPE NORTE"",
        ""CodigoPostal"": ""S3574XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1966,
        ""Nombre"": ""COLONIA ALTHUAUS"",
        ""CodigoPostal"": ""S3572XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1967,
        ""Nombre"": ""COLONIA ELLA"",
        ""CodigoPostal"": ""S3572XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1968,
        ""Nombre"": ""COLONIA SAN MANUEL"",
        ""CodigoPostal"": ""S3563XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1969,
        ""Nombre"": ""COLONIA SANTA CATALINA"",
        ""CodigoPostal"": ""S3572XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1970,
        ""Nombre"": ""DESVIO DR BARROS PAZOS"",
        ""CodigoPostal"": ""S3569XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1971,
        ""Nombre"": ""DESVIO KILOMETRO 392"",
        ""CodigoPostal"": ""S3551XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1972,
        ""Nombre"": ""DISTRITO 3 ISLETAS"",
        ""CodigoPostal"": ""S3575XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1973,
        ""Nombre"": ""EL ARAZA"",
        ""CodigoPostal"": ""S3563XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1974,
        ""Nombre"": ""EL CARMEN DE AVELLANEDA"",
        ""CodigoPostal"": ""S3561XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1975,
        ""Nombre"": ""EL CEIBALITO"",
        ""CodigoPostal"": ""S3575XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1976,
        ""Nombre"": ""EL RABON"",
        ""CodigoPostal"": ""S3592XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1977,
        ""Nombre"": ""EL RICARDITO"",
        ""CodigoPostal"": ""S3572XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1978,
        ""Nombre"": ""EL SOMBRERITO"",
        ""CodigoPostal"": ""S3585XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1979,
        ""Nombre"": ""EL TAPIALITO"",
        ""CodigoPostal"": ""S3575XAI"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1980,
        ""Nombre"": ""EL TIMBO"",
        ""CodigoPostal"": ""S3561XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1981,
        ""Nombre"": ""EWALD"",
        ""CodigoPostal"": ""S3561XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1982,
        ""Nombre"": ""FLOR DE ORO"",
        ""CodigoPostal"": ""S3575XAJ"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1983,
        ""Nombre"": ""FLORENCIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1984,
        ""Nombre"": ""FLORIDA"",
        ""CodigoPostal"": ""S3565XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1985,
        ""Nombre"": ""FORTIN CHARRUA"",
        ""CodigoPostal"": ""S3060XAP"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1986,
        ""Nombre"": ""GOLONDRINA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1987,
        ""Nombre"": ""GUADALUPE NORTE"",
        ""CodigoPostal"": ""S3574XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1988,
        ""Nombre"": ""GUASUNCHO"",
        ""CodigoPostal"": ""S3581XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1989,
        ""Nombre"": ""INGENIERO CHANOURDIE"",
        ""CodigoPostal"": ""S3575XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1990,
        ""Nombre"": ""INGENIERO GARMENDIA"",
        ""CodigoPostal"": ""S3586XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1991,
        ""Nombre"": ""INGENIERO GERMANIA"",
        ""CodigoPostal"": ""S3586XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1992,
        ""Nombre"": ""ISLA TIGRE"",
        ""CodigoPostal"": ""S3583XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1993,
        ""Nombre"": ""ISLETA"",
        ""CodigoPostal"": ""S3581XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1994,
        ""Nombre"": ""KILOMETRO 17"",
        ""CodigoPostal"": ""S3565XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1995,
        ""Nombre"": ""KILOMETRO 23"",
        ""CodigoPostal"": ""S3589XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1996,
        ""Nombre"": ""KILOMETRO 30"",
        ""CodigoPostal"": ""S3565XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1997,
        ""Nombre"": ""KILOMETRO 320"",
        ""CodigoPostal"": ""S3551XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1998,
        ""Nombre"": ""KILOMETRO 392"",
        ""CodigoPostal"": ""S3551XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 1999,
        ""Nombre"": ""KILOMETRO 403"",
        ""CodigoPostal"": ""S3585XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2000,
        ""Nombre"": ""KILOMETRO 408"",
        ""CodigoPostal"": ""S3580XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2001,
        ""Nombre"": ""KILOMETRO 41"",
        ""CodigoPostal"": ""S3583XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2002,
        ""Nombre"": ""KILOMETRO 421"",
        ""CodigoPostal"": ""S3585XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2003,
        ""Nombre"": ""KILOMETRO 67"",
        ""CodigoPostal"": ""S3581XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2004,
        ""Nombre"": ""LA BLANCA"",
        ""CodigoPostal"": ""S3551XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2005,
        ""Nombre"": ""LA CELIA"",
        ""CodigoPostal"": ""S3569XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2006,
        ""Nombre"": ""LA CLARITA"",
        ""CodigoPostal"": ""S3585XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2007,
        ""Nombre"": ""LA DIAMELA"",
        ""CodigoPostal"": ""S3569XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2008,
        ""Nombre"": ""LA ESMERALDA"",
        ""CodigoPostal"": ""S3560XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2009,
        ""Nombre"": ""LA JOSEFINA"",
        ""CodigoPostal"": ""S3565XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2010,
        ""Nombre"": ""LA LOLA"",
        ""CodigoPostal"": ""S3567XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2011,
        ""Nombre"": ""LA POTASA"",
        ""CodigoPostal"": ""S3563XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2012,
        ""Nombre"": ""LA RESERVA"",
        ""CodigoPostal"": ""S3581XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2013,
        ""Nombre"": ""LA SARITA"",
        ""CodigoPostal"": ""S3563XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2014,
        ""Nombre"": ""LA SELVA"",
        ""CodigoPostal"": ""S3551XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2015,
        ""Nombre"": ""LA VANGUARDIA"",
        ""CodigoPostal"": ""S3561XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2016,
        ""Nombre"": ""LA ZULEMA"",
        ""CodigoPostal"": ""S3551XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2017,
        ""Nombre"": ""LANTERI"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2018,
        ""Nombre"": ""LAS DELICIAS"",
        ""CodigoPostal"": ""S3551XAI"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2019,
        ""Nombre"": ""LAS GARZAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2020,
        ""Nombre"": ""LAS MERCEDES"",
        ""CodigoPostal"": ""S3516XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2021,
        ""Nombre"": ""LAS PALMAS"",
        ""CodigoPostal"": ""S3555XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2022,
        ""Nombre"": ""LAS SIETE PROVINCIAS"",
        ""CodigoPostal"": ""S3575XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2023,
        ""Nombre"": ""LAS TOSCAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2024,
        ""Nombre"": ""LOS CLAROS"",
        ""CodigoPostal"": ""S3551XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2025,
        ""Nombre"": ""LOS LAPACHOS"",
        ""CodigoPostal"": ""S3575XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2026,
        ""Nombre"": ""LOS LAURELES"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2027,
        ""Nombre"": ""LOS LEONES"",
        ""CodigoPostal"": ""S3551XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2028,
        ""Nombre"": ""MALABRIGO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2029,
        ""Nombre"": ""MOCOVI"",
        ""CodigoPostal"": ""S3581XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2030,
        ""Nombre"": ""MOUSSY"",
        ""CodigoPostal"": ""S3561XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2031,
        ""Nombre"": ""NICANOR E MOLINAS"",
        ""CodigoPostal"": ""S3563XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2032,
        ""Nombre"": ""OBRAJE INDIO MUERTO"",
        ""CodigoPostal"": ""S3589XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2033,
        ""Nombre"": ""OBRAJE SAN JUAN"",
        ""CodigoPostal"": ""S3589XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2034,
        ""Nombre"": ""PAUL GROUSSAC"",
        ""CodigoPostal"": ""S3585XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2035,
        ""Nombre"": ""POTRERO GUASUNCHO"",
        ""CodigoPostal"": ""S3589XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2036,
        ""Nombre"": ""PUERTO OCAMPO"",
        ""CodigoPostal"": ""S3580XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2037,
        ""Nombre"": ""PUERTO PIRACUA"",
        ""CodigoPostal"": ""S3516XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2038,
        ""Nombre"": ""PUERTO PIRACUACITO"",
        ""CodigoPostal"": ""S3592XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2039,
        ""Nombre"": ""PUERTO RECONQUISTA"",
        ""CodigoPostal"": ""S3567XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2040,
        ""Nombre"": ""RECONQUISTA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2041,
        ""Nombre"": ""DEST AERONAUTICO MILIT RECONQU"",
        ""CodigoPostal"": ""S3567XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2042,
        ""Nombre"": ""SAN ALBERTO"",
        ""CodigoPostal"": ""S3565XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2043,
        ""Nombre"": ""SAN ANTONIO DE OBLIGADO"",
        ""CodigoPostal"": ""S3587XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2044,
        ""Nombre"": ""SAN ROQUE"",
        ""CodigoPostal"": ""S3553XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2045,
        ""Nombre"": ""SAN VICENTE"",
        ""CodigoPostal"": ""S3580XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2046,
        ""Nombre"": ""SANTA ANA"",
        ""CodigoPostal"": ""S3575XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2047,
        ""Nombre"": ""TACUARENDI"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2048,
        ""Nombre"": ""VICTOR MANUEL SEGUNDO"",
        ""CodigoPostal"": ""S3563XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2049,
        ""Nombre"": ""VILLA ADELA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2050,
        ""Nombre"": ""VILLA ANA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2051,
        ""Nombre"": ""VILLA GUILLERMINA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2052,
        ""Nombre"": ""VILLA OCAMPO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2053,
        ""Nombre"": ""YAGUARETE"",
        ""CodigoPostal"": ""S3586XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2054,
        ""Nombre"": ""ACEBAL"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2055,
        ""Nombre"": ""AERO CLUB ROSARIO"",
        ""CodigoPostal"": ""S2132XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2056,
        ""Nombre"": ""ALBARELLOS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2057,
        ""Nombre"": ""ALVAREZ"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2058,
        ""Nombre"": ""ALVEAR"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2059,
        ""Nombre"": ""ARMINDA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2060,
        ""Nombre"": ""ARROYO SECO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2061,
        ""Nombre"": ""BERNARD"",
        ""CodigoPostal"": ""S2119XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2062,
        ""Nombre"": ""CAMINO MONTE FLORES"",
        ""CodigoPostal"": ""S2126XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2063,
        ""Nombre"": ""CAMPO CALVO"",
        ""CodigoPostal"": ""S2123XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2064,
        ""Nombre"": ""CARMEN DEL SAUCE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2065,
        ""Nombre"": ""COLONIA ESCRIBANO"",
        ""CodigoPostal"": ""S2103XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2066,
        ""Nombre"": ""CORONEL AGUIRRE"",
        ""CodigoPostal"": ""S2124XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2067,
        ""Nombre"": ""CORONEL BOGADO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2068,
        ""Nombre"": ""CORONEL DOMINGUEZ"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2069,
        ""Nombre"": ""CRESTA"",
        ""CodigoPostal"": ""S2126XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2070,
        ""Nombre"": ""EL CARAMELO"",
        ""CodigoPostal"": ""S2105XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2071,
        ""Nombre"": ""ESTACION ERASTO"",
        ""CodigoPostal"": ""S2119XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2072,
        ""Nombre"": ""ESTANCIA LA MARIA"",
        ""CodigoPostal"": ""S2105XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2073,
        ""Nombre"": ""ESTANCIA SAN ANTONIO"",
        ""CodigoPostal"": ""S2107XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2074,
        ""Nombre"": ""FIGHIERA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2075,
        ""Nombre"": ""FUNES"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2076,
        ""Nombre"": ""GENERAL LAGOS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2077,
        ""Nombre"": ""GRANADERO B BARGAS"",
        ""CodigoPostal"": ""S2132XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2078,
        ""Nombre"": ""GRANADERO BAIGORRIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2079,
        ""Nombre"": ""IBARLUCEA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2080,
        ""Nombre"": ""LA CAROLINA"",
        ""CodigoPostal"": ""S2105XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2081,
        ""Nombre"": ""LA CERAMICA Y CUYO"",
        ""CodigoPostal"": ""S2000XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2082,
        ""Nombre"": ""LA LATA"",
        ""CodigoPostal"": ""S2126XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2083,
        ""Nombre"": ""LICEO AERONAUTICO MILITAR"",
        ""CodigoPostal"": ""S2132XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2084,
        ""Nombre"": ""LINKS"",
        ""CodigoPostal"": ""S2132XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2085,
        ""Nombre"": ""LOS MUCHACHOS"",
        ""CodigoPostal"": ""S2105XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2086,
        ""Nombre"": ""MONTE FLORES"",
        ""CodigoPostal"": ""S2101XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2087,
        ""Nombre"": ""PAGANINI"",
        ""CodigoPostal"": ""S2152XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2088,
        ""Nombre"": ""PEREYRA LUCENA"",
        ""CodigoPostal"": ""S2105XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2089,
        ""Nombre"": ""PEREZ"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2090,
        ""Nombre"": ""PUEBLO ESTHER"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2100,
        ""Nombre"": ""SAN SEBASTIAN"",
        ""CodigoPostal"": ""S2121XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2101,
        ""Nombre"": ""SOLDINI"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2102,
        ""Nombre"": ""TALLERES"",
        ""CodigoPostal"": ""S2121XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2103,
        ""Nombre"": ""URANGA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2104,
        ""Nombre"": ""22 DE MAYO"",
        ""CodigoPostal"": ""S2124XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2105,
        ""Nombre"": ""VILLA AMELIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2106,
        ""Nombre"": ""VILLA AMERICA"",
        ""CodigoPostal"": ""S2121XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2107,
        ""Nombre"": ""VILLA GOBERNADOR GALVEZ"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2108,
        ""Nombre"": ""VILLA LYLY TALLERES"",
        ""CodigoPostal"": ""S2121XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2109,
        ""Nombre"": ""VILLA SAN DIEGO"",
        ""CodigoPostal"": ""S2124XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2110,
        ""Nombre"": ""ZAMPONI"",
        ""CodigoPostal"": ""S2105XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2111,
        ""Nombre"": ""ZAVALLA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2112,
        ""Nombre"": ""ARRUFO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2113,
        ""Nombre"": ""DHO"",
        ""CodigoPostal"": ""S3070XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2115,
        ""Nombre"": ""ALEJANDRA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2116,
        ""Nombre"": ""CAMPO COUBERT"",
        ""CodigoPostal"": ""S3056XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2118,
        ""Nombre"": ""COLONIA DURAN"",
        ""CodigoPostal"": ""S3553XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2119,
        ""Nombre"": ""COLONIA EL TOBA"",
        ""CodigoPostal"": ""S3553XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2120,
        ""Nombre"": ""COLONIA FRANCESA"",
        ""CodigoPostal"": ""S3005XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2121,
        ""Nombre"": ""COLONIA LA MORA"",
        ""CodigoPostal"": ""S3045XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2122,
        ""Nombre"": ""COLONIA LA NICOLASA"",
        ""CodigoPostal"": ""S3056XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2123,
        ""Nombre"": ""COLONIA MASCIAS"",
        ""CodigoPostal"": ""S3001XAW"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2124,
        ""Nombre"": ""COLONIA SAGER"",
        ""CodigoPostal"": ""S3553XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2125,
        ""Nombre"": ""COLONIA TERESA"",
        ""CodigoPostal"": ""S3005XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2126,
        ""Nombre"": ""EL PAJARO BLANCO"",
        ""CodigoPostal"": ""S3051XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2127,
        ""Nombre"": ""LA BRAVA"",
        ""CodigoPostal"": ""S3045XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2128,
        ""Nombre"": ""LA CATALINA"",
        ""CodigoPostal"": ""S3572XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2129,
        ""Nombre"": ""LA LOMA"",
        ""CodigoPostal"": ""S3555XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2130,
        ""Nombre"": ""LOS CARDENALES"",
        ""CodigoPostal"": ""S3005XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2131,
        ""Nombre"": ""LOS CORRALITOS"",
        ""CodigoPostal"": ""S3051XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2132,
        ""Nombre"": ""LOS CUERVOS"",
        ""CodigoPostal"": ""S3555XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2133,
        ""Nombre"": ""LOS OSOS"",
        ""CodigoPostal"": ""S3051XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2134,
        ""Nombre"": ""ROMANG"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2135,
        ""Nombre"": ""SAN JAVIER"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2136,
        ""Nombre"": ""CASALEGNO"",
        ""CodigoPostal"": ""S2248XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2137,
        ""Nombre"": ""GALVEZ"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2138,
        ""Nombre"": ""LAS BANDURRIAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2139,
        ""Nombre"": ""SAN MARTIN DE TOURS"",
        ""CodigoPostal"": ""S2255XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2140,
        ""Nombre"": ""ABIPONES"",
        ""CodigoPostal"": ""S3042XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2141,
        ""Nombre"": ""ARRASCAETA"",
        ""CodigoPostal"": ""S3046XAK"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2142,
        ""Nombre"": ""AVICHUNCHO"",
        ""CodigoPostal"": ""S3040XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2143,
        ""Nombre"": ""CACIQUE ARIACAIQUIN"",
        ""CodigoPostal"": ""S3041XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2144,
        ""Nombre"": ""CAMPO BERRAZ"",
        ""CodigoPostal"": ""S3046XAL"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2145,
        ""Nombre"": ""CAYASTACITO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2146,
        ""Nombre"": ""COLONIA ANGELONI"",
        ""CodigoPostal"": ""S3048XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2147,
        ""Nombre"": ""COLONIA DOLORES"",
        ""CodigoPostal"": ""S3045XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2148,
        ""Nombre"": ""COLONIA EL OCHENTA"",
        ""CodigoPostal"": ""S3042XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2149,
        ""Nombre"": ""COLONIA LA BLANCA"",
        ""CodigoPostal"": ""S3052XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2150,
        ""Nombre"": ""COLONIA LA PENCA"",
        ""CodigoPostal"": ""S3045XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2151,
        ""Nombre"": ""COLONIA MANUEL MENCHACA"",
        ""CodigoPostal"": ""S3046XAM"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2152,
        ""Nombre"": ""COLONIA SILVA"",
        ""CodigoPostal"": ""S3042XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2153,
        ""Nombre"": ""COLONIA SOL DE MAYO"",
        ""CodigoPostal"": ""S3048XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2154,
        ""Nombre"": ""COLONIA TRES REYES"",
        ""CodigoPostal"": ""S3048XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2155,
        ""Nombre"": ""ESQUINA GRANDE"",
        ""CodigoPostal"": ""S3040XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2156,
        ""Nombre"": ""ESTHER"",
        ""CodigoPostal"": ""S3036XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2157,
        ""Nombre"": ""FIVES LILLE"",
        ""CodigoPostal"": ""S3054XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2158,
        ""Nombre"": ""GOBERNADOR CRESPO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2159,
        ""Nombre"": ""GUARANIES"",
        ""CodigoPostal"": ""S3054XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2160,
        ""Nombre"": ""KILOMETRO 95"",
        ""CodigoPostal"": ""S3046XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2161,
        ""Nombre"": ""LA CAMILA"",
        ""CodigoPostal"": ""S3054XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2162,
        ""Nombre"": ""LA CLORINDA"",
        ""CodigoPostal"": ""S3021XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2163,
        ""Nombre"": ""LA CRIOLLA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2164,
        ""Nombre"": ""LA JULIA"",
        ""CodigoPostal"": ""S3046XAN"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2165,
        ""Nombre"": ""LA ROSA"",
        ""CodigoPostal"": ""S3042XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2166,
        ""Nombre"": ""LA SEMENTERA"",
        ""CodigoPostal"": ""S3038XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2167,
        ""Nombre"": ""LOS OLIVOS"",
        ""CodigoPostal"": ""S3046XAO"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2168,
        ""Nombre"": ""LOS SALADILLOS"",
        ""CodigoPostal"": ""S3041XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2169,
        ""Nombre"": ""LUCIANO LEIVA"",
        ""CodigoPostal"": ""S3048XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2170,
        ""Nombre"": ""MARCELINO ESCALADA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2171,
        ""Nombre"": ""MIGUEL ESCALADA"",
        ""CodigoPostal"": ""S3046XAP"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2173,
        ""Nombre"": ""NARE"",
        ""CodigoPostal"": ""S3046XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2174,
        ""Nombre"": ""NUEVA UKRANIA"",
        ""CodigoPostal"": ""S3046XAI"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2175,
        ""Nombre"": ""PAIKIN"",
        ""CodigoPostal"": ""S3046XAJ"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2176,
        ""Nombre"": ""PEDRO GOMEZ CELLO"",
        ""CodigoPostal"": ""S3054XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2177,
        ""Nombre"": ""PUEBLO SAN BERNARDO"",
        ""CodigoPostal"": ""S3048XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2178,
        ""Nombre"": ""RAMAYON"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2179,
        ""Nombre"": ""SAN JUSTO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2180,
        ""Nombre"": ""SAN MARTIN NORTE"",
        ""CodigoPostal"": ""S3045XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2181,
        ""Nombre"": ""SOLEDAD"",
        ""CodigoPostal"": ""S3025XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2182,
        ""Nombre"": ""SOUTO MAYOR"",
        ""CodigoPostal"": ""S3025XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2183,
        ""Nombre"": ""VERA MUJICA"",
        ""CodigoPostal"": ""S3040XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2184,
        ""Nombre"": ""VERA Y PINTADO"",
        ""CodigoPostal"": ""S3054XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2185,
        ""Nombre"": ""VIDELA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2186,
        ""Nombre"": ""VILLA LASTENIA"",
        ""CodigoPostal"": ""S3042XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2187,
        ""Nombre"": ""ALDAO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2188,
        ""Nombre"": ""ARSENAL DE GUERRA SAN LORENZO"",
        ""CodigoPostal"": ""S2156XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2189,
        ""Nombre"": ""BARLETT"",
        ""CodigoPostal"": ""S2175XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2190,
        ""Nombre"": ""BORGHI"",
        ""CodigoPostal"": ""S2156XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2191,
        ""Nombre"": ""CAPITAN BERMUDEZ"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2193,
        ""Nombre"": ""CERANA"",
        ""CodigoPostal"": ""S2202XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2194,
        ""Nombre"": ""COLONIA CLODOMIRA"",
        ""CodigoPostal"": ""S2123XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2195,
        ""Nombre"": ""COLONIA EL CARMEN"",
        ""CodigoPostal"": ""S2138XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2196,
        ""Nombre"": ""CORONEL ARNOLD"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2197,
        ""Nombre"": ""CULLEN"",
        ""CodigoPostal"": ""S2202XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2198,
        ""Nombre"": ""EL TRANSITO"",
        ""CodigoPostal"": ""S2202XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2199,
        ""Nombre"": ""FABRICA MILITAR SAN LORENZO"",
        ""CodigoPostal"": ""S2156XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2200,
        ""Nombre"": ""FRAY LUIS BELTRAN"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2201,
        ""Nombre"": ""FUENTES"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2202,
        ""Nombre"": ""GRANADEROS"",
        ""CodigoPostal"": ""S2156XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2203,
        ""Nombre"": ""JESUS MARIA"",
        ""CodigoPostal"": ""S2204XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2204,
        ""Nombre"": ""JUAN ORTIZ"",
        ""CodigoPostal"": ""S2154XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2205,
        ""Nombre"": ""KILOMETRO 319"",
        ""CodigoPostal"": ""S2154XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2206,
        ""Nombre"": ""LA SALADA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2207,
        ""Nombre"": ""LAS QUINTAS"",
        ""CodigoPostal"": ""S2200XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2208,
        ""Nombre"": ""LUIS PALACIOS"",
        ""CodigoPostal"": ""S2142XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2209,
        ""Nombre"": ""MAIZALES"",
        ""CodigoPostal"": ""S2119XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2210,
        ""Nombre"": ""PINO DE SAN LORENZO"",
        ""CodigoPostal"": ""S2200XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2211,
        ""Nombre"": ""PUEBLO KIRSTON"",
        ""CodigoPostal"": ""S2202XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2212,
        ""Nombre"": ""PUERTO DE SAN LORENZO"",
        ""CodigoPostal"": ""S2200XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2213,
        ""Nombre"": ""PUERTO GRAL SAN MARTIN"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2214,
        ""Nombre"": ""PUJATO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2215,
        ""Nombre"": ""RICARDONE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2216,
        ""Nombre"": ""ROLDAN"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2217,
        ""Nombre"": ""SAN GERONIMO"",
        ""CodigoPostal"": ""S2136XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2218,
        ""Nombre"": ""SAN JERONIMO SUD"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2219,
        ""Nombre"": ""SAN LORENZO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2220,
        ""Nombre"": ""SEMINO"",
        ""CodigoPostal"": ""S2138XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2221,
        ""Nombre"": ""TIMBUES JOSE MARIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2222,
        ""Nombre"": ""TTE HIPOLITO BOUCHARD"",
        ""CodigoPostal"": ""S2156XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2223,
        ""Nombre"": ""VICENTE ECHEVARRIA"",
        ""CodigoPostal"": ""S2142XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2224,
        ""Nombre"": ""VILLA CASSINI"",
        ""CodigoPostal"": ""S2154XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2225,
        ""Nombre"": ""VILLA GARIBALDI"",
        ""CodigoPostal"": ""S2156XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2226,
        ""Nombre"": ""VILLA MARGARITA"",
        ""CodigoPostal"": ""S2156XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2227,
        ""Nombre"": ""VILLA MUGUETA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2228,
        ""Nombre"": ""VILLA PORUCCI"",
        ""CodigoPostal"": ""S2123XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2229,
        ""Nombre"": ""AVENA"",
        ""CodigoPostal"": ""S2449XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2230,
        ""Nombre"": ""BARRIO BELGRANO ORTIZ"",
        ""CodigoPostal"": ""S2440XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2231,
        ""Nombre"": ""CAMPO CASTRO"",
        ""CodigoPostal"": ""S2148XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2232,
        ""Nombre"": ""CAMPO FAGGIANO"",
        ""CodigoPostal"": ""S2440XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2234,
        ""Nombre"": ""CARLOS PELLEGRINI"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2235,
        ""Nombre"": ""CASAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2236,
        ""Nombre"": ""COLONIA BELGRANO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2237,
        ""Nombre"": ""COLONIA CASTELAR"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2238,
        ""Nombre"": ""COLONIA LA YERBA"",
        ""CodigoPostal"": ""S2451XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2239,
        ""Nombre"": ""COLONIA SAN FRANCISCO"",
        ""CodigoPostal"": ""S2527XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2240,
        ""Nombre"": ""COLONIA SANTA ANITA"",
        ""CodigoPostal"": ""S2451XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2241,
        ""Nombre"": ""CRISPI"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2242,
        ""Nombre"": ""EL TREBOL"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2243,
        ""Nombre"": ""ESMERALDITA"",
        ""CodigoPostal"": ""S2401XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2244,
        ""Nombre"": ""GRANADERO BRASILIO BUSTOS"",
        ""CodigoPostal"": ""S2257XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2245,
        ""Nombre"": ""KILOMETRO 443"",
        ""CodigoPostal"": ""S2454XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2246,
        ""Nombre"": ""KILOMETRO 465"",
        ""CodigoPostal"": ""S2456XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2247,
        ""Nombre"": ""LANDETA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2248,
        ""Nombre"": ""LAS PETACAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2249,
        ""Nombre"": ""LOS CARDOS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2250,
        ""Nombre"": ""MARIA SUSANA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2251,
        ""Nombre"": ""PIAMONTE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2252,
        ""Nombre"": ""SAN JORGE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2253,
        ""Nombre"": ""SAN JOSE FRONTERA"",
        ""CodigoPostal"": ""S2401XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2254,
        ""Nombre"": ""SAN MARTIN DE LAS ESCOBAS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2255,
        ""Nombre"": ""SASTRE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2256,
        ""Nombre"": ""TAIS"",
        ""CodigoPostal"": ""S2535XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2257,
        ""Nombre"": ""TRAILL"",
        ""CodigoPostal"": ""S2456XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2258,
        ""Nombre"": ""WILDERMUTH"",
        ""CodigoPostal"": ""S2257XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2259,
        ""Nombre"": ""CALCHAQUI"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2260,
        ""Nombre"": ""CAMPO MONTE LA VIRUELA"",
        ""CodigoPostal"": ""S3551XAK"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2262,
        ""Nombre"": ""CARAGUATAY"",
        ""CodigoPostal"": ""S3557XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2263,
        ""Nombre"": ""COLMENA"",
        ""CodigoPostal"": ""S3551XAM"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2264,
        ""Nombre"": ""COLONIA LA MARIA"",
        ""CodigoPostal"": ""S3056XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2265,
        ""Nombre"": ""COLONIA LA NEGRA"",
        ""CodigoPostal"": ""S3054XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2266,
        ""Nombre"": ""COSTA DEL TOBA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2267,
        ""Nombre"": ""DESVIO KILOMETRO 282"",
        ""CodigoPostal"": ""S3551XAN"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2268,
        ""Nombre"": ""EL DIECISIETE"",
        ""CodigoPostal"": ""S3553XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2269,
        ""Nombre"": ""EL TAJAMAR"",
        ""CodigoPostal"": ""S3565XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2270,
        ""Nombre"": ""ESPIN"",
        ""CodigoPostal"": ""S3056XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2271,
        ""Nombre"": ""ESTANCIA LAS GAMAS"",
        ""CodigoPostal"": ""S3057XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2272,
        ""Nombre"": ""ESTANCIA LOS PALMARES"",
        ""CodigoPostal"": ""S3057XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2273,
        ""Nombre"": ""ESTANCIA PAVENHAN"",
        ""CodigoPostal"": ""S3057XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2274,
        ""Nombre"": ""FORTIN CHILCAS"",
        ""CodigoPostal"": ""S3553XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2275,
        ""Nombre"": ""FORTIN OLMOS"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2276,
        ""Nombre"": ""GARABATO"",
        ""CodigoPostal"": ""S3551XAS"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2277,
        ""Nombre"": ""GUAYCURU"",
        ""CodigoPostal"": ""S3551XAO"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2278,
        ""Nombre"": ""INTIYACO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2279,
        ""Nombre"": ""KILOMETRO 213"",
        ""CodigoPostal"": ""S3050XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2280,
        ""Nombre"": ""KILOMETRO 302"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2281,
        ""Nombre"": ""KILOMETRO 49"",
        ""CodigoPostal"": ""S3589XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2282,
        ""Nombre"": ""KILOMETRO 54"",
        ""CodigoPostal"": ""S3589XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2284,
        ""Nombre"": ""LA GALLARETA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2285,
        ""Nombre"": ""LA GUAMPITA"",
        ""CodigoPostal"": ""S3056XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2286,
        ""Nombre"": ""LA HOSCA"",
        ""CodigoPostal"": ""S3050XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2287,
        ""Nombre"": ""LA ORIENTAL"",
        ""CodigoPostal"": ""S3054XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2288,
        ""Nombre"": ""LA SARNOSA"",
        ""CodigoPostal"": ""S3057XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2289,
        ""Nombre"": ""LOS AMORES"",
        ""CodigoPostal"": ""S3551XAT"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2290,
        ""Nombre"": ""LOS GALPONES"",
        ""CodigoPostal"": ""S3050XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2291,
        ""Nombre"": ""LOS PALMARES"",
        ""CodigoPostal"": ""S3057XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2292,
        ""Nombre"": ""LOS TABANOS DESVIO KM 366"",
        ""CodigoPostal"": ""S3551XAU"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2293,
        ""Nombre"": ""MARGARITA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2295,
        ""Nombre"": ""OGILIVE"",
        ""CodigoPostal"": ""S3551XAV"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2296,
        ""Nombre"": ""29"",
        ""CodigoPostal"": ""S3553XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2297,
        ""Nombre"": ""PARAJE TRAGNAGHI"",
        ""CodigoPostal"": ""S3551XAP"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2298,
        ""Nombre"": ""PAVENHAN"",
        ""CodigoPostal"": ""S3057XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2299,
        ""Nombre"": ""POZO DE LOS INDIOS"",
        ""CodigoPostal"": ""S3551XAQ"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2300,
        ""Nombre"": ""SANTA FELICIA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2301,
        ""Nombre"": ""SANTA LUCIA"",
        ""CodigoPostal"": ""S3553XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2302,
        ""Nombre"": ""TARTAGAL"",
        ""CodigoPostal"": ""S3565XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2303,
        ""Nombre"": ""TOBA"",
        ""CodigoPostal"": ""S3551XAR"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2304,
        ""Nombre"": ""VELAZQUEZ"",
        ""CodigoPostal"": ""S3550XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 2305,
        ""Nombre"": ""VERA"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 15702,
        ""Nombre"": ""SAN EUGENIO"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 16391,
        ""Nombre"": ""SANTA FE"",
        ""CodigoPostal"": """",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17109,
        ""Nombre"": ""ESTANCIA ACHALA"",
        ""CodigoPostal"": ""S3060XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17119,
        ""Nombre"": ""EL TRIANGULO"",
        ""CodigoPostal"": ""S3060XAN"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17132,
        ""Nombre"": ""FORTIN TACURU"",
        ""CodigoPostal"": ""S3060XAL"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17169,
        ""Nombre"": ""LAS ARENAS"",
        ""CodigoPostal"": ""S3060XAM"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17209,
        ""Nombre"": ""SAN BERNARDO"",
        ""CodigoPostal"": ""S3061XAL"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17217,
        ""Nombre"": ""SIN PEREZA"",
        ""CodigoPostal"": ""S3060XAO"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17312,
        ""Nombre"": ""LAS LIEBRES"",
        ""CodigoPostal"": ""S2520XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17321,
        ""Nombre"": ""AREQUITO"",
        ""CodigoPostal"": ""S2183XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17368,
        ""Nombre"": ""AURELIA NORTE"",
        ""CodigoPostal"": ""S2318XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17372,
        ""Nombre"": ""AURELIA SUD"",
        ""CodigoPostal"": ""S2318XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17426,
        ""Nombre"": ""EL BAYO"",
        ""CodigoPostal"": ""S2300XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17434,
        ""Nombre"": ""ESTACION MARIA JUANA"",
        ""CodigoPostal"": ""S2445XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17443,
        ""Nombre"": ""FASSI"",
        ""CodigoPostal"": ""S2300XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17450,
        ""Nombre"": ""HUGENTOBLER"",
        ""CodigoPostal"": ""S2317XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17481,
        ""Nombre"": ""PUEBLO TERRAGNI"",
        ""CodigoPostal"": ""S2300XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17491,
        ""Nombre"": ""SIERRA PEREYRA"",
        ""CodigoPostal"": ""S2300XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17497,
        ""Nombre"": ""TRES COLONIAS"",
        ""CodigoPostal"": ""S2300XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17667,
        ""Nombre"": ""COPACABANA"",
        ""CodigoPostal"": ""S2919XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17762,
        ""Nombre"": ""ACHAVAL RODRIGUEZ"",
        ""CodigoPostal"": ""S2344XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17811,
        ""Nombre"": ""COLONIA DOS ROSAS"",
        ""CodigoPostal"": ""S2349XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17851,
        ""Nombre"": ""ESTANCIA SAN FRANCISCO"",
        ""CodigoPostal"": ""S2344XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 17965,
        ""Nombre"": ""COLONIA LOS ZAPALLOS"",
        ""CodigoPostal"": ""S3003XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18092,
        ""Nombre"": ""CICARELLI"",
        ""CodigoPostal"": ""S2500XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18155,
        ""Nombre"": ""LAS TROJAS"",
        ""CodigoPostal"": ""S2500XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18167,
        ""Nombre"": ""VILLA LA RIBERA"",
        ""CodigoPostal"": ""S2500XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18337,
        ""Nombre"": ""COLONIA SAN JOSE"",
        ""CodigoPostal"": ""S3016XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18340,
        ""Nombre"": ""BOCA P 25"",
        ""CodigoPostal"": ""S2600XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18343,
        ""Nombre"": ""CHATEAUBRIAND"",
        ""CodigoPostal"": ""S2600XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18346,
        ""Nombre"": ""ESTACION TEODELINA"",
        ""CodigoPostal"": ""S2600XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18350,
        ""Nombre"": ""SANTA TERESA"",
        ""CodigoPostal"": ""S6106XAK"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18354,
        ""Nombre"": ""RABIOLA"",
        ""CodigoPostal"": ""S2600XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18355,
        ""Nombre"": ""VILLA ESTELA"",
        ""CodigoPostal"": ""S2726XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18356,
        ""Nombre"": ""CAMPO UBAJO"",
        ""CodigoPostal"": ""S3560XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18358,
        ""Nombre"": ""COLONIA EL VEINTICINCO"",
        ""CodigoPostal"": ""S3560XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18360,
        ""Nombre"": ""COLONIA YAGUARETE"",
        ""CodigoPostal"": ""S3560XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18363,
        ""Nombre"": ""LAS ANINTAS"",
        ""CodigoPostal"": ""S3560XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18365,
        ""Nombre"": ""LAS CATALINAS"",
        ""CodigoPostal"": ""S3560XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18368,
        ""Nombre"": ""LAS GARSITAS"",
        ""CodigoPostal"": ""S3560XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18372,
        ""Nombre"": ""TRES BOCAS"",
        ""CodigoPostal"": ""S3560XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18375,
        ""Nombre"": ""COLONIA SAN ROQUE"",
        ""CodigoPostal"": ""S3005XAI"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18376,
        ""Nombre"": ""EL CEIBO"",
        ""CodigoPostal"": ""S3005XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18378,
        ""Nombre"": ""EL GUSANO"",
        ""CodigoPostal"": ""S3005XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18379,
        ""Nombre"": ""EL PARA"",
        ""CodigoPostal"": ""S3005XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18381,
        ""Nombre"": ""OMBU NORTE"",
        ""CodigoPostal"": ""S3005XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18384,
        ""Nombre"": ""ASUNCION MARIA"",
        ""CodigoPostal"": ""S3040XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18388,
        ""Nombre"": ""EL SOMBRERERO"",
        ""CodigoPostal"": ""S3046XAQ"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18391,
        ""Nombre"": ""ESTANCIA LA CONSTANCIA"",
        ""CodigoPostal"": ""S3040XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18393,
        ""Nombre"": ""ESTANCIA PRUSIA"",
        ""CodigoPostal"": ""S3040XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18396,
        ""Nombre"": ""LA CAPILLA"",
        ""CodigoPostal"": ""S3040XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18401,
        ""Nombre"": ""MASCIAS"",
        ""CodigoPostal"": ""S3041XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18407,
        ""Nombre"": ""SCHIFFNER"",
        ""CodigoPostal"": ""S2451XAC"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18412,
        ""Nombre"": ""ALLENDE"",
        ""CodigoPostal"": ""S3550XAE"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18415,
        ""Nombre"": ""CERRITO"",
        ""CodigoPostal"": ""S3550XAD"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18419,
        ""Nombre"": ""EL 38"",
        ""CodigoPostal"": ""S3550XAG"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18421,
        ""Nombre"": ""EL 44"",
        ""CodigoPostal"": ""S3550XAH"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18423,
        ""Nombre"": ""EL CINCUENTA"",
        ""CodigoPostal"": ""S3550XAF"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18425,
        ""Nombre"": ""EL BONETE"",
        ""CodigoPostal"": ""S3550XAA"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18429,
        ""Nombre"": ""PARAJE KILOMETRO 12"",
        ""CodigoPostal"": ""S3550XAB"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 18431,
        ""Nombre"": ""PUEBLO GOLONDRINA"",
        ""CodigoPostal"": ""S3551XAJ"",
        ""ID_Provincia"": ""S""
      },
      {
        ""IDLocalidad"": 20949,
        ""Nombre"": ""ROSARIO"",
        ""CodigoPostal"": ""2000"",
        ""ID_Provincia"": ""S""
      }
    ]";
  }
}
