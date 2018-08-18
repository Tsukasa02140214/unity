
using UnityEngine;
using UnityEditor;


//Editorフォルダ 入れる
public class importer : AssetPostprocessor
{
    //Unityに画像をインポートした時呼び出し
    void OnPostprocessTexture(Texture2D texture)
    {
        //Texture設定
        TextureImporter importer = assetImporter as TextureImporter;

        // null ではない場合
        if (importer != null)
        {
            //Pathに .pngが含まれてれいれば
            if (assetPath.Contains(".png"))
            {
                //TextureType Sprite
                importer.textureType = TextureImporterType.Sprite;
                //maxサイズ 128 
                importer.maxTextureSize = 128;
                //設定保存
                importer.SaveAndReimport();
            }
        }
    }

}
