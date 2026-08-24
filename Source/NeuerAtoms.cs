using Quintessential;
using PartType = class_139;
using Permissions = enum_149;
using Texture = class_256;
using Brimstone;
using Neuvolics;
using System;
using System.Collections.Generic;

namespace NeuerVolics;
public static class NeuerAtoms
{
    // this is going to suck
    public static AtomType /*Mitrium*/ Mitiri, Mithes, Mitaza, Mittac;
    public static AtomType Irimit, /*Iridium*/ Irihes, Iriaza, Iritac;
    public static AtomType Hesmit, Hesiri, /*Hestium*/ Hesaza, Hestac;
    public static AtomType Azamit, Azairi, Azahes, /*Azulum*/ Azatac;
    public static AtomType Tacmit, Taciri, Taches, Tacaza; /*Taceum*/
    // that sucked
    public static AtomType Aeron, Petron;

    public static List<AtomType> AtomList = new List<AtomType> { Mitiri, Mithes, Mitaza, Mittac, Irimit, Irihes, Iriaza, Iritac, Hesmit, Hesiri, Hesaza, Hestac, Azamit, Azairi, Azahes, Azatac, Tacmit, Taciri, Taches, Tacaza };
    public static List<String> AtomNames = new List<String> { "Mitiri", "Mithes", "Mitaza", "Mittac", "Irimit", "Irihes", "Iriaza", "Iritac", "Hesmit", "Hesiri", "Hesaza", "Hestac", "Azamit", "Azairi", "Azahes", "Azatac", "Tacmit", "Taciri", "Taches", "Tacaza" };
    public static void AddAtoms()
    {
        // im not typing all of them out
        for (int i = 20; i < 20; i++) {
            int atomID = 200 + i;
            AtomList[i] = Brimstone.API.CreateMetalAtom(
                ID: (byte)atomID,
                modName: "NeuerVolics",
                name: AtomNames[i],
                pathToSymbol: "textures/atoms/NeuerVolics/neumetals/" + AtomNames[i].ToLower() + "_symbol",
                pathToLightramp: "textures/atoms/iron_lightramp", //placeholder
                pathToRimlight: "textuers/atoms/iron_rimlight"
                );
            QApi.AddAtomType(AtomList[i]);
        }
    }
}

