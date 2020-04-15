using System;

namespace MyFirstAPIApp
{
    public class Movie
    {
        public Feed feed { get; set; }
    }

    public class Feed
    {
        public Author author { get; set; }
        public Entry[] entry { get; set; }
        public Updated updated { get; set; }
        public Rights rights { get; set; }
        public Title title { get; set; }
        public Icon icon { get; set; }
        public Link1[] link { get; set; }
        public Id id { get; set; }
    }

    public class Author
    {
        public Name name { get; set; }
        public Uri uri { get; set; }
    }

    public class Name
    {
        public string label { get; set; }
    }

    public class Uri
    {
        public string label { get; set; }
    }

    public class Updated
    {
        public DateTime label { get; set; }
    }

    public class Rights
    {
        public string label { get; set; }
    }

    public class Title
    {
        public string label { get; set; }
    }

    public class Icon
    {
        public string label { get; set; }
    }

    public class Id
    {
        public string label { get; set; }
    }

    public class Entry
    {
        public ImName imname { get; set; }
        public Rights1 rights { get; set; }
        public ImImage[] imimage { get; set; }
        public Summary summary { get; set; }
        public ImRentalprice imrentalPrice { get; set; }
        public ImPrice imprice { get; set; }
        public ImContenttype imcontentType { get; set; }
        public Title1 title { get; set; }
        public Link[] link { get; set; }
        public Id1 id { get; set; }
        public ImArtist imartist { get; set; }
        public Category category { get; set; }
        public ImReleasedate imreleaseDate { get; set; }
    }

    public class ImName
    {
        public string label { get; set; }
    }

    public class Rights1
    {
        public string label { get; set; }
    }

    public class Summary
    {
        public string label { get; set; }
    }

    public class ImRentalprice
    {
        public string label { get; set; }
        public Attributes attributes { get; set; }
    }

    public class Attributes
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class ImPrice
    {
        public string label { get; set; }
        public Attributes1 attributes { get; set; }
    }

    public class Attributes1
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class ImContenttype
    {
        public Attributes2 attributes { get; set; }
    }

    public class Attributes2
    {
        public string term { get; set; }
        public string label { get; set; }
    }

    public class Title1
    {
        public string label { get; set; }
    }

    public class Id1
    {
        public string label { get; set; }
        public Attributes3 attributes { get; set; }
    }

    public class Attributes3
    {
        public string imid { get; set; }
    }

    public class ImArtist
    {
        public string label { get; set; }
    }

    public class Category
    {
        public Attributes4 attributes { get; set; }
    }

    public class Attributes4
    {
        public string imid { get; set; }
        public string term { get; set; }
        public string scheme { get; set; }
        public string label { get; set; }
    }

    public class ImReleasedate
    {
        public DateTime label { get; set; }
        public Attributes5 attributes { get; set; }
    }

    public class Attributes5
    {
        public string label { get; set; }
    }

    public class ImImage
    {
        public string label { get; set; }
        public Attributes6 attributes { get; set; }
    }

    public class Attributes6
    {
        public string height { get; set; }
    }

    public class Link
    {
        public Attributes7 attributes { get; set; }
        public ImDuration imduration { get; set; }
    }

    public class Attributes7
    {
        public string rel { get; set; }
        public string type { get; set; }
        public string href { get; set; }
        public string title { get; set; }
        public string imassetType { get; set; }
    }

    public class ImDuration
    {
        public string label { get; set; }
    }

    public class Link1
    {
        public Attributes8 attributes { get; set; }
    }

    public class Attributes8
    {
        public string rel { get; set; }
        public string type { get; set; }
        public string href { get; set; }
    }

}