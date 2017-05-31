using System;

namespace duplicate_finder.App
{
    public class Processor_Statistical : Processor
    {
        protected override bool compare_files(byte[] file_origin, byte[] file_current)
        {
            int i = 0, pos = 0, k = 0;
            byte j = 0, pos_current = 0, pos_origin = 0;
            byte occurence_current = 0, occurence_origin = 0;
            double delta = 0, num = 0;
            match_proximity = 0;

            for (i = 0; i < number_of_samples; i++)
            {
                byte[,] char_pos_sample_origin = new byte[256, 200];
                byte[,] char_pos_sample_current = new byte[256, 200];
                byte[] char_occurence_sample_origin = new byte[256];
                byte[] char_occurence_sample_current = new byte[256];

                pos = i * size_of_sample;
                for (j = 1; j < size_of_sample+1; j++ )
                {
                    char_pos_sample_origin[file_origin[pos], char_occurence_sample_origin[file_origin[pos]]] = j;
                    char_pos_sample_current[file_current[pos], char_occurence_sample_current[file_current[pos]]] = j;

                    char_occurence_sample_origin[file_origin[pos]]++;
                    char_occurence_sample_current[file_current[pos]]++;
                    pos++;
                }

                pos = i * size_of_sample;
                for (j = 0; j < 255; j++)
                {
                    occurence_origin = char_occurence_sample_origin[j];
                    occurence_current = char_occurence_sample_current[j];

                    if (occurence_origin != 0 && occurence_current != 0)
                    {
                        if (occurence_current > occurence_origin)
                        {
                            delta = ((double)occurence_origin) / ((double)occurence_current);
                        }
                        else
                        {
                            delta = ((double)occurence_current) / ((double)occurence_origin);
                        }
                        match_proximity += delta;
                        num++;
                    }

                    for (k = 0; k < size_of_sample; k++)
                    {
                        pos_origin = char_pos_sample_origin[j, k];
                        pos_current = char_pos_sample_current[j, k];

                        if (pos_origin != 0 && pos_current != 0)
                        {
                            if (pos_current > pos_origin)
                            {
                                delta = (1.0 - ((double)(pos_current - pos_origin)) / 200);
                            }
                            else
                            {
                                delta = (1.0 - ((double)(pos_origin - pos_current)) / 200);
                            }
                            delta = Math.Sqrt(delta);
                            match_proximity += delta;
                            num++;
                        }
                        else break;
                    }
                    pos++;
                }
            }
            match_proximity = match_proximity / num;
            if (match_proximity > content_match_settings)
                return true;
            else return false;
        }
    }
}
