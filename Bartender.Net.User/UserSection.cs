﻿using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;
using Bartender.Net.User.Ammunition;
using Bartender.Net.User.Attacks;
using Bartender.Net.User.AttacksFull;
using Bartender.Net.User.Bars;
using Bartender.Net.User.Basic;
using Bartender.Net.User.BattleStats;
using Bartender.Net.User.Cooldowns;
using Bartender.Net.User.CrimeRecord;
using Bartender.Net.User.Crimes;
using Bartender.Net.User.DisplayCase;
using Bartender.Net.User.Education;
using Bartender.Net.User.Equipment;
using Bartender.Net.User.Events;
using Bartender.Net.User.Gym;
using Bartender.Net.User.HoF;
using Bartender.Net.User.Honors;
using Bartender.Net.User.Icons;
using Bartender.Net.User.JobPoints;
using Bartender.Net.User.Log;
using Bartender.Net.User.Medals;
using Bartender.Net.User.Merits;
using Bartender.Net.User.Messages;
using Bartender.Net.User.Missions;
using Bartender.Net.User.Money;
using Bartender.Net.User.Networth;
using Bartender.Net.User.NewEvents;
using Bartender.Net.User.NewMessages;
using Bartender.Net.User.Notifications;
using Bartender.Net.User.Perks;
using Bartender.Net.User.PersonalStats;
using Bartender.Net.User.Profile;
using Bartender.Net.User.Property;
using Bartender.Net.User.PublicStatus;
using Bartender.Net.User.Refills;
using Bartender.Net.User.Skills;
using Bartender.Net.User.Social;
using Bartender.Net.User.Stocks;
using Bartender.Net.User.Travel;
using Bartender.Net.User.WeaponExp;
using Bartender.Net.User.WorkStats;

namespace Bartender.Net.User;

public class UserSection : ISection {
    public string Name => "user";

    public static readonly Selection Ammo = new ("ammo", AccessLevel.Minimal, typeof (AmmoRoot));
    public static readonly Selection Attacks = new ("attacks", AccessLevel.Limited, typeof (UserAttacksRoot));
    public static readonly Selection AttacksFull = new ("attacksfull", AccessLevel.Limited, typeof (UserAttacksFullRoot));
    public static readonly Selection Bars = new ("bars", AccessLevel.Minimal, typeof (BarsRoot));
    public static readonly Selection Basic = new ("basic", AccessLevel.Public, typeof (UserBasic));
    public static readonly Selection BattleStats = new ("battlestats", AccessLevel.Limited, typeof (BattleStatsRoot));
    public static readonly Selection Cooldowns = new ("cooldowns", AccessLevel.Minimal, typeof (CooldownsRoot));
    public static readonly Selection Crimes = new ("crimes", AccessLevel.Minimal, typeof (CrimesRoot));
    public static readonly Selection CriminalRecord = new ("criminalrecord", AccessLevel.Public, typeof (CriminalRecordRoot));
    public static readonly Selection Discord = new ("discord", AccessLevel.Limited, typeof (DiscordRoot));
    public static readonly Selection Display = new ("display", AccessLevel.Public, typeof (DisplayCaseRoot));
    public static readonly Selection Education = new ("education", AccessLevel.Minimal, typeof (EducationRoot));
    public static readonly Selection Equipment = new ("equipment", AccessLevel.Minimal, typeof (EquipmentRoot));
    public static readonly Selection Events = new ("events", AccessLevel.Limited, typeof (EventsRoot));
    public static readonly Selection Gym = new ("gym", AccessLevel.Minimal, typeof (GymRoot));
    public static readonly Selection Hof = new ("hof", AccessLevel.Limited, typeof (HallOfFameRoot));
    public static readonly Selection Honors = new ("honors", AccessLevel.Minimal, typeof (HonorsRoot));
    public static readonly Selection Icons = new ("icons", AccessLevel.Public, typeof (IconsRoot));
    //public static readonly Selection Inventory = new ("inventory", AccessLevel.Minimal, typeof(InventoryRoot));
    public static readonly Selection JobPoints = new ("jobpoints", AccessLevel.Minimal, typeof (JobPointsRoot));
    public static readonly Selection Log = new ("log", AccessLevel.Full, typeof (LogRoot));
    public static readonly Selection Medals = new ("medals", AccessLevel.Public, typeof (MedalsRoot));
    public static readonly Selection Merits = new ("merits", AccessLevel.Minimal, typeof (MeritsRoot));
    public static readonly Selection Messages = new ("messages", AccessLevel.Limited, typeof (MessagesRoot));
    public static readonly Selection Missions = new ("missions", AccessLevel.Minimal, typeof (MissionsRoot));
    public static readonly Selection Money = new ("money", AccessLevel.Limited, typeof (MoneyRoot));
    public static readonly Selection Networth = new ("networth", AccessLevel.Limited, typeof (NetworthRoot));
    public static readonly Selection NewEvents = new ("newevents", AccessLevel.Minimal, typeof (NewUserEventsRoot));
    public static readonly Selection NewMessages = new ("newmessages", AccessLevel.Minimal, typeof (NewUserMessagesRoot));
    public static readonly Selection Notifications = new ("notifications", AccessLevel.Minimal, typeof (UserNotificationsRoot));
    public static readonly Selection Perks = new ("perks", AccessLevel.Minimal, typeof (PerksRoot));
    public static readonly Selection PersonalStats = new ("personalstats", AccessLevel.Public, typeof (PersonalStatsRoot));
    public static readonly Selection Profile = new ("profile", AccessLevel.Public, typeof (UserProfileRoot));
    public static readonly Selection Properties = new ("properties", AccessLevel.Public, typeof (PropertiesRoot));
    public static readonly Selection PublicStatus = new ("publicstatus", AccessLevel.Public, typeof (PublicStatusRoot));
    public static readonly Selection Refills = new ("refills", AccessLevel.Minimal, typeof (RefillsRoot));
    //public static readonly Selection Reports = new ("reports", AccessLevel.Limited, typeof(ReportsRoot));
    //public static readonly Selection Revives = new ("revives", AccessLevel.Minimal, typeof(RevivesRoot));
    //public static readonly Selection RevivesFull = new ("revivesfull", AccessLevel.Minimal, typeof(RevivesFullRoot));
    public static readonly Selection Skills = new ("skills", AccessLevel.Minimal, typeof (SkillsRoot));
    public static readonly Selection Stocks = new ("stocks", AccessLevel.Limited, typeof (UserStocksRoot));
    public static readonly Selection Travel = new ("travel", AccessLevel.Minimal, typeof (TravelRoot));
    public static readonly Selection WeaponExp = new ("weaponexp", AccessLevel.Minimal, typeof (WeaponExpRoot));
    public static readonly Selection WorkStats = new ("workstats", AccessLevel.Minimal, typeof (WorkStatsRoot));

    public IEnumerable<Selection> Selections {
        get {
            yield return Ammo;
            yield return Attacks;
            yield return AttacksFull;
            yield return Bars;
            yield return Basic;
            yield return BattleStats;
            yield return Cooldowns;
            yield return Crimes;
            yield return CriminalRecord;
            yield return Discord;
            yield return Display;
            yield return Education;
            yield return Equipment;
            yield return Events;
            yield return Gym;
            yield return Hof;
            yield return Honors;
            yield return Icons;
            //yield return Inventory;
            yield return JobPoints;
            yield return Log;
            yield return Medals;
            yield return Merits;
            yield return Messages;
            yield return Missions;
            yield return Money;
            yield return Networth;
            yield return NewEvents;
            yield return NewMessages;
            yield return Notifications;
            yield return Perks;
            yield return PersonalStats;
            yield return Profile;
            yield return Properties;
            yield return PublicStatus;
            yield return Refills;
            //yield return Reports;
            //yield return Revives;
            //yield return RevivesFull;
            yield return Skills;
            yield return Stocks;
            yield return Travel;
            yield return WeaponExp;
            yield return WorkStats;
        }
    }
}
