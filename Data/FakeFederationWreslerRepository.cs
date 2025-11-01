using System;
using System.Collections.Generic;
using MyRestApiServer.Models;

namespace MyRestApiServer.Data;

public static class FakeFederationWrestlerRepository
{
    private static readonly List<Wrestler> _wrestlers = new()
    {
        new Wrestler
        {
            Id = 1,
            Name = "Becky Lynch",
            Alias = "The Man",
            FinishingMove = "Manhandle Slam"
        },
        new Wrestler
        {
            Id = 2,
            Name = "Charlotte Flair",
            Alias = "The Queen",
            FinishingMove = "Figure-Eight Leglock"
        },
        new Wrestler
        {
            Id = 3,
            Name = "Bianca Belair",
            Alias = "The EST of WWE",
            FinishingMove = "K.O.D. (Kiss of Death)"
        },
        new Wrestler
        {
            Id = 4,
            Name = "Rhea Ripley",
            Alias = "Mami",
            FinishingMove = "Riptide"
        },
        new Wrestler
        {
            Id = 5,
            Name = "Bayley",
            Alias = "Role Model",
            FinishingMove = "Rose Plant"
        },
        new Wrestler
        {
            Id = 6,
            Name = "Asuka",
            Alias = "The Empress of Tomorrow",
            FinishingMove = "Asuka Lock"
        },
        new Wrestler
        {
            Id = 7,
            Name = "Sasha Banks",
            Alias = "The Boss",
            FinishingMove = "Bank Statement"
        },
        new Wrestler
        {
            Id = 8,
            Name = "Alexa Bliss",
            Alias = "Five Feet of Fury",
            FinishingMove = "Twisted Bliss"
        }
    };

    public static IEnumerable<Wrestler> GetAllWrestlers() => _wrestlers;

    public static Wrestler? GetWrestlerById(int id) => _wrestlers.Find(w => w.Id == id);

    public static void AddWrestler(Wrestler wrestler) => _wrestlers.Add(wrestler);

    public static void DeleteWrestler(int id) => _wrestlers.RemoveAll(w => w.Id == id);
}