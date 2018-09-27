using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using BitHeroesCharacterEditor.Model;
using BitHeroesCharacterEditor.ViewModel;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.Database
{
    public class SqliteService
    {
        private readonly IMessenger _messenger;
        private readonly string _cs;

        public SqliteService(IMessenger messenger)
        {
            _messenger = messenger;

            var relativePath = @"Model\BitHeroesDb.sqlite";
            var parentdir = Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath);
            var myString = parentdir.Remove(parentdir.Length - 4, 4);
            var absolutePath = Path.Combine(myString, relativePath);
            _cs = $@"Data Source={absolutePath};Version=3;";
        }

        public List<BaseItemViewModel> SelectAllEquipment()
        {
            var list = new List<BaseItemViewModel>();
            
            using (var con = new SQLiteConnection(_cs))
            {
                con.Open();

                using (var cmd = new SQLiteCommand("select * from Equipment", con))
                {
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            BaseItemViewModel item;

                            var type = (EquipmentType)rdr.GetInt32(2);

                            switch (type)
                            {
                                case EquipmentType.Slot:
                                    return null;
                                case EquipmentType.Mainhand:
                                    item = new MainhandViewModel(_messenger);
                                    break;
                                case EquipmentType.Offhand:
                                    item = new OffhandViewModel(_messenger);
                                    break;
                                case EquipmentType.Head:
                                    item = new HeadViewModel(_messenger);
                                    break;
                                case EquipmentType.Body:
                                    item = new BodyViewModel(_messenger);
                                    break;
                                case EquipmentType.Neck:
                                    item = new NeckViewModel(_messenger);
                                    break;
                                case EquipmentType.Ring:
                                    item = new RingViewModel(_messenger);
                                    break;
                                case EquipmentType.Accessory:
                                    item = new AccessoryViewModel(_messenger);
                                    break;
                                case EquipmentType.Pet:
                                    item = new PetViewModel(_messenger);
                                    break;
                                case EquipmentType.Mount:
                                    item = new MountViewModel(_messenger);
                                    break;
                                default:
                                    return null;
                            }

                            item.ItemName = rdr.GetString(0);
                            item.Tier = rdr.GetInt32(1);
                            item.Slot = (EquipmentType)rdr.GetInt32(2);
                            item.Quality = (ItemQuality)rdr.GetInt32(3);
                            item.Stats = new StatsViewModel
                            {
                                Power = rdr.GetInt32(5),
                                Stamina = rdr.GetInt32(6),
                                Agility = rdr.GetInt32(7),
                                AltPower = rdr.GetInt32(8),
                                AltStamina = rdr.GetInt32(9),
                                AltAgility = rdr.GetInt32(10),
                                DamageBonus = rdr.GetInt32(11),
                                HealthBonus = rdr.GetInt32(12),
                                SpeedBonus = rdr.GetInt32(13),
                                CriticalChance = rdr.GetInt32(14),
                                CriticalDamage = rdr.GetInt32(15),
                                DamageEnrage = rdr.GetInt32(16),
                                DualStrike = rdr.GetInt32(17),
                                EmpowerChance = rdr.GetInt32(18),
                                QuadStrike = rdr.GetInt32(19),
                                EvadeChance = rdr.GetInt32(20),
                                BlockChance = rdr.GetInt32(21),
                                LifeSteal = rdr.GetInt32(22),
                                DeflectChance = rdr.GetInt32(23),
                                AbsorbChance = rdr.GetInt32(24),
                                DamageReduction = rdr.GetInt32(25),
                                RedirectChance = rdr.GetInt32(26),
                                ItemFind = rdr.GetInt32(27),
                                GoldFind = rdr.GetInt32(28),
                                Experience = rdr.GetInt32(29),
                                MovementSpeed = rdr.GetInt32(30),
                                CaptureRate = rdr.GetInt32(31)
                            };

                            list.Add(item);
                        }
                    }
                }

                con.Close();
            }

            return list;
        }

        public List<BaseItemViewModel> SelectAllRunes()
        {
            var list = new List<BaseItemViewModel>();

            using (var con = new SQLiteConnection(_cs))
            {
                con.Open();

                using (var cmd = new SQLiteCommand("select * from Runes", con))
                {
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            BaseRuneViewModel baseRune;

                            var type = (RuneType)rdr.GetInt32(1);

                            switch (type)
                            {
                                case RuneType.Rune:
                                    return null;
                                case RuneType.Minor:
                                    baseRune = new MinorRuneViewModel(_messenger);
                                    break;
                                case RuneType.Major:
                                    baseRune = new MajorRuneViewModel(_messenger);
                                    break;
                                case RuneType.Meta:
                                    baseRune = new MetaRuneViewModel(_messenger);
                                    break;
                                default:
                                    return null;
                            }

                            baseRune.ItemName = rdr.GetString(0);
                            baseRune.Type = (RuneType)rdr.GetInt32(1);
                            baseRune.Quality = (ItemQuality)rdr.GetInt32(2);
                            baseRune.Stats = new StatsViewModel()
                            {
                                Power = rdr.GetInt32(3),
                                Stamina = rdr.GetInt32(4),
                                Agility = rdr.GetInt32(5),
                                DamageBonus = rdr.GetInt32(6),
                                HealthBonus = rdr.GetInt32(7),
                                SpeedBonus = rdr.GetInt32(8),
                                CriticalChance = rdr.GetInt32(9),
                                CriticalDamage = rdr.GetInt32(10),
                                DamageEnrage = rdr.GetInt32(11),
                                DualStrike = rdr.GetInt32(12),
                                EmpowerChance = rdr.GetInt32(13),
                                QuadStrike = rdr.GetInt32(14),
                                EvadeChance = rdr.GetInt32(15),
                                BlockChance = rdr.GetInt32(16),
                                LifeSteal = rdr.GetInt32(17),
                                DeflectChance = rdr.GetInt32(18),
                                AbsorbChance = rdr.GetInt32(19),
                                DamageReduction = rdr.GetInt32(20),
                                RedirectChance = rdr.GetInt32(21),
                                ItemFind = rdr.GetInt32(22),
                                GoldFind = rdr.GetInt32(23),
                                Experience = rdr.GetInt32(24),
                                MovementSpeed = rdr.GetInt32(25),
                                CaptureRate = rdr.GetInt32(26)
                            };

                            list.Add(baseRune);
                        }
                    }
                }

                con.Close();
            }

            return list;
        }
    }
}