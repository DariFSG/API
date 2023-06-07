namespace КП.Model
{
    public class VideoOfDay
    {
        public List<Contents> contents { get; set; }

        public string GetTitle(int index)
        {
            List<Contents> contents = this.contents;
            return contents[index].video.title;
        }

        public string GetVideoId(int index)
        {
            List<Contents> contents = this.contents;
            return contents[index].video.videoId;
        }
    }

    public class Contents
    {
        public Video video { get; set; }
    }

    public class Video
    {
        public string title { get; set; }
        public string videoId { get; set ; }        
    }    
}
