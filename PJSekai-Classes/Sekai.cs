using MessagePack;

// Version 4.0.0
namespace Sekai
{
    [MessagePackObject(keyAsPropertyName: true)]
    public class AssetBundleInfo
    {
        public String version;
        public Dictionary<String, AssetBundleElement> bundles;
    }

    [MessagePackObject(keyAsPropertyName: true)]
    public class AssetBundleElement
    {
        public String bundleName;
        public String cacheFileName;
        public String cacheDirectoryName;
        public String hash;
        public String category;
        public UInt32 crc;
        public Int64 fileSize;
        public String[] dependencies;
        public String[] paths;
        public Boolean isBuiltin;
    }
}
