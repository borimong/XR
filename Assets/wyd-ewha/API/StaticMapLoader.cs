using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Cerberus_Platform_API
{
    public class StaticMapLoader : MonoBehaviour
    {
        public RawImage mapRawImage;

        [Header("맵 정보 입력")]
        public string strBaseURL = "https://api.vworld.kr/req/image?service=image&request=getmap&key=";
        public string latitude = "";
        public string longitude = "";
        public int zoomLevel = 14;
        public int mapWidth;
        public int mapHeight;
        public string strAPIKey = "691D67B5-5A2F-3BA3-9EC2-335DE63F0B3D";
        public GeoPath geoPath; // Path Scriptable Object

        private void Start()
        {
            StartCoroutine(VWorldMapLoad());
        }

        IEnumerator VWorldMapLoad()
        {
            // yield return null;

            StringBuilder str = new StringBuilder();
            str.Append(strBaseURL.ToString());
            str.Append(strAPIKey.ToString());
            str.Append("&format=png");
            str.Append("&basemap=GRAPHIC");
            str.Append("&center=");
            str.Append(longitude.ToString());
            str.Append(",");
            str.Append(latitude.ToString());
            str.Append("&crs=epsg:4326");
            str.Append("&zoom=");
            str.Append(zoomLevel.ToString());
            str.Append("&size=");
            str.Append(mapWidth.ToString());
            str.Append(",");
            str.Append(mapHeight.ToString());

            str.Append("&marker=point:");
            str.Append(geoPath.geoLocationPath[0].longitude.ToString("F7"));
            str.Append(" ");
            str.Append(geoPath.geoLocationPath[0].latitude.ToString("F7"));
            str.Append("|label:출발지|color:blue|image:img01");

            str.Append("&marker=point:");
            str.Append(geoPath.geoLocationPath[geoPath.geoLocationPath.Count-1].longitude.ToString("F7"));
            str.Append(" ");
            str.Append(geoPath.geoLocationPath[geoPath.geoLocationPath.Count-1].latitude.ToString("F7"));
            str.Append("|label:도착지|color:red|image:img09");


            Debug.Log(str.ToString());

            // Request API Texture
            UnityWebRequest request = UnityWebRequestTexture.GetTexture(str.ToString());

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log(request.error);
            }
            else
            {
                mapRawImage.texture = DownloadHandlerTexture.GetContent(request);
            }
        }
    }
}
