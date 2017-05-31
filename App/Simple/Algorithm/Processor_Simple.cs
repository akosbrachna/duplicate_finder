namespace duplicate_finder.App
{
    public class Processor_Simple : Processor
    {
        protected override bool compare_files(byte[] file_origin, byte[] file_current)
        {
            int i = 0, j = 0, pos = 0;
            match_proximity = 0;

            for (i = 0; i < number_of_samples; i++)
            {
                pos = i * size_of_sample;
                for (j = 0; j < size_of_sample; j++)
                {
                    if (file_origin[pos + j] == file_current[pos + j])
                        match_proximity++;
                }
            }
            match_proximity = match_proximity / (double)(number_of_samples*size_of_sample);
            if (match_proximity > content_match_settings)
                return true;
            else return false;
        }
    }
}
