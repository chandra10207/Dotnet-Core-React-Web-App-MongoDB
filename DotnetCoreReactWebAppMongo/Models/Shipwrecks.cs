using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

// Mapping Model for Mongo Collection
namespace DotnetCoreReactWebAppMongo.Models
{
	[BsonIgnoreExtraElements]
	public class Shipwrecks
	{
		[BsonId]
		public ObjectId Id { get; set; }

		[BsonElement("feature_type")]
		public string FeatureType { get; set; }

		[BsonElement("chart")]
		public string Chart { get; set; }

		[BsonElement("latdec")]
		public double Latitude { get; set; }

        [BsonElement("londec")]
        public double longitude { get; set; }

		//[BsonExtraElements]
		//public object[] Bucket { get; set; }

	}
}

