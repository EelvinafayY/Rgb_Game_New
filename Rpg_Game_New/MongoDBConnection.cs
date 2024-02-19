using MongoDB.Bson;
using MongoDB.Driver;
using Rpg_Game_New.Heroes;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New
{
    public class MongoDBConnection
    {
        public static string connectionString = "mongodb://localhost";

        private static IMongoDatabase ConnectToDatabase(string databaseName)
        {
            var client = new MongoClient(connectionString);
            return client.GetDatabase(databaseName);
        }
        public static void Post<T>(string databaseName, string collectionName, T record)
        {
            var database = MongoDBConnection.ConnectToDatabase(databaseName);
            var collection = database.GetCollection<T>(collectionName);
            collection.InsertOne(record);
        }
        public static List<T> Get<T>(string databaseName, string collectionName)
        {
            var database = MongoDBConnection.ConnectToDatabase(databaseName);
            var collection = database.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Empty;
            var result = collection.Find(filter).ToList();

            return result;
        }
        public static List<Rogue> GetRogue(string basename)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Rgb_Game");
            var collection = database.GetCollection<Rogue>("CharacterCollection");
            var filter = Builders<Rogue>.Filter.Eq("BaseName", basename);
            var result = collection.Find(filter).ToList();
            return result;
        }
        public static List<Wizard> GetWizard(string basename)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Rgb_Game");
            var collection = database.GetCollection<Wizard>("CharacterCollection");
            var filter = Builders<Wizard>.Filter.Eq("BaseName", basename);
            var result = collection.Find(filter).ToList();
            return result;
        }
        public static List<Warrior> GetWarrior(string basename)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Rgb_Game");
            var collection = database.GetCollection<Warrior>("CharacterCollection");
            var filter = Builders<Warrior>.Filter.Eq("BaseName", basename);
            var result = collection.Find(filter).ToList();
            return result;
        }
        public static void Put<T>(string databaseName, string collectionName, ObjectId id, T record)
        {
            var database = MongoDBConnection.ConnectToDatabase(databaseName);
            var collection = database.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("_id", id);
            var result = collection.ReplaceOne(filter, record);
        }
        public static void Delete<T>(string databaseName, string collectionName, string id)
        {
            var database = MongoDBConnection.ConnectToDatabase(databaseName);
            var collection = database.GetCollection<T>(collectionName);

            var filter = Builders<T>.Filter.Eq("_id", id);
            collection.DeleteOne(filter);
        }

        public static void CreateCharacterWarrior(Character character)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Rgb_Game");
            var collection = database.GetCollection<Character>("CharacterCollection");
            collection.InsertOne(character);
        }

        public static void CreateCharacterRogue(Character character)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Rgb_Game");
            var collection = database.GetCollection<Character>("CharacterCollection");
            collection.InsertOne(character);
        }

        public static void CreateCharacterWizard(Character character)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Rgb_Game");
            var collection = database.GetCollection<Character>("CharacterCollection");
            collection.InsertOne(character);
        }

        public static void UpdateRogue(Rogue rogue)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Rgb_Game");
            var collection = database.GetCollection<Rogue>("CharacterCollection");
            var filter = Builders<Rogue>.Filter.Eq(i => i._id, rogue._id);
            collection.ReplaceOne(filter, rogue);
        }

        public static void UpdateWarrior(Warrior warrior)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Rgb_Game");
            var collection = database.GetCollection<Warrior>("CharacterCollection");
            var filter = Builders<Warrior>.Filter.Eq(i => i._id, warrior._id);
            collection.ReplaceOne(filter, warrior);
        }

        public static void UpdateWizard(Wizard wizard)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Rgb_Game");
            var collection = database.GetCollection<Wizard>("CharacterCollection");
            var filter = Builders<Wizard>.Filter.Eq(i => i._id, wizard._id);
            collection.ReplaceOne(filter, wizard);
        }

        //public static Character GetCharacterWarrior(string name)
        //{
        //    var client = new MongoClient(connectionString);
        //    var database = client.GetDatabase("Strategy");
        //    var collection = database.GetCollection<Character>("UserCollection");
        //    var character = collection.Find(x => x.Name == name).FirstOrDefault();
        //    return character;
        //}
    }
}
