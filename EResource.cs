class EResource {

  public EResource() {

  }

  public static string LoadResource() {

    var res = "";

    var assembly = System.Reflection.Assembly.GetExecutingAssembly();
    var stream = assembly.GetManifestResourceStream("ResourceA");
    if (stream == null) {
      return "リソース取得は失敗";
    }
    using(var reader = new StreamReader(stream)) {
      res = reader.ReadToEnd();
    }
    return res;
  }

  public static byte[]? LoadBinaryResource(string name = "Binary1") {
    var assembly = System.Reflection.Assembly.GetExecutingAssembly();
    using var stream = assembly.GetManifestResourceStream(name);
    if (stream == null) {
      return null;
    }
    using var memoryStream = new MemoryStream();
    stream.CopyTo(memoryStream);
    return memoryStream.ToArray();
  }

  public static Stream? GetResourceStream(string name = "Binary1") {
    var assembly = System.Reflection.Assembly.GetExecutingAssembly();
    return assembly.GetManifestResourceStream(name);
  }
}