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
                                Power = (double)rdr.GetDecimal(5),
                                Stamina = (double)rdr.GetDecimal(6),
                                Agility = (double)rdr.GetDecimal(7),
                                AltPower = (double)rdr.GetDecimal(8),
                                AltStamina = (double)rdr.GetDecimal(9),
                                AltAgility = (double)rdr.GetDecimal(10),
                                DamageBonus = (double)rdr.GetDecimal(11),
                                HealthBonus = (double)rdr.GetDecimal(12),
                                SpeedBonus = (double)rdr.GetDecimal(13),
                                CriticalChance = (double)rdr.GetDecimal(14),
                                CriticalDamage = (double)rdr.GetDecimal(15),
                                DamageEnrage = (double)rdr.GetDecimal(16),
                                DualStrike = (double)rdr.GetDecimal(17),
                                EmpowerChance = (double)rdr.GetDecimal(18),
                                QuadStrike = (double)rdr.GetDecimal(19),
                                EvadeChance = (double)rdr.GetDecimal(20),
                                BlockChance = (double)rdr.GetDecimal(21),
                                LifeSteal = (double)rdr.GetDecimal(22),
                                DeflectChance = (double)rdr.GetDecimal(23),
                                AbsorbChance = (double)rdr.GetDecimal(24),
                                DamageReduction = (double)rdr.GetDecimal(25),
                                RedirectChance = (double)rdr.GetDecimal(26),
                                ItemFind = (double)rdr.GetDecimal(27),
                                GoldFind = (double)rdr.GetDecimal(28),
                                Experience = (double)rdr.GetDecimal(29),
                                MovementSpeed = (double)rdr.GetDecimal(30),
                                CaptureRate = (double)rdr.GetDecimal(31)
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
                                Power = (double)rdr.GetDecimal(3),
                                Stamina = (double)rdr.GetDecimal(4),
                                Agility = (double)rdr.GetDecimal(5),
                                DamageBonus = (double)rdr.GetDecimal(6),
                                HealthBonus = (double)rdr.GetDecimal(7),
                                SpeedBonus = (double)rdr.GetDecimal(8),
                                CriticalChance = (double)rdr.GetDecimal(9),
                                CriticalDamage = (double)rdr.GetDecimal(10),
                                DamageEnrage = (double)rdr.GetDecimal(11),
                                DualStrike = (double)rdr.GetDecimal(12),
                                EmpowerChance = (double)rdr.GetDecimal(13),
                                QuadStrike = (double)rdr.GetDecimal(14),
                                EvadeChance = (double)rdr.GetDecimal(15),
                                BlockChance = (double)rdr.GetDecimal(16),
                                LifeSteal = (double)rdr.GetDecimal(17),
                                DeflectChance = (double)rdr.GetDecimal(18),
                                AbsorbChance = (double)rdr.GetDecimal(19),
                                DamageReduction = (double)rdr.GetDecimal(20),
                                RedirectChance = (double)rdr.GetDecimal(21),
                                ItemFind = (double)rdr.GetDecimal(22),
                                GoldFind = (double)rdr.GetDecimal(23),
                                Experience = (double)rdr.GetDecimal(24),
                                MovementSpeed = (double)rdr.GetDecimal(25),
                                CaptureRate = (double)rdr.GetDecimal(26)
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