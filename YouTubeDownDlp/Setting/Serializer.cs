using System.Text.Json;

namespace YouTubeDownDlp.Setting
{
    internal static class Serializer
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions()
        {
            // 出力を分かりやすくする
            WriteIndented = true,
        };

        public static void Save<T>(T obj, string path)
        {
            try
            {
                string json = JsonSerializer.Serialize(obj, jsonSerializerOptions);
                File.WriteAllText(path, json);
            }
            catch
            {

            }
        }

        public static T Load<T>(string path) where T : new()
        {
            try
            {
                if (!File.Exists(path))
                {
                    // ファイルが存在しない場合は新規作成してから読み込む
                    Save(new T(), path);
                    return new T();
                }
                 
                string json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<T>(json) ?? new T();
            }
            catch
            {
                return new T();
            }
        }
    }
}
