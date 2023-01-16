using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Notes.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.Views
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public partial class NoteEntryPage : ContentPage
    {
        public NoteEntryPage()
        {
            InitializeComponent();

            BindingContext = new Note();
        }

        public string ItemId
        {
            set
            {
                // {Binding Text}에서 글을 작성하면 실시간으로 갱신이 되는것인가?
                LoadNote(value);
            }
        }


        private void LoadNote(string filename)
        {
            try
            {
                Note note = new Note
                {
                    Filename = filename,
                    Text = File.ReadAllText(filename),
                    Date = File.GetCreationTime(filename)
                };

                BindingContext = note;
            } 
            catch (Exception e)
            {
                Console.WriteLine("Failed to load note");
            }
        }

        async void OnSaveButonClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("[debug] --> : [OnSaveButtonClicked] sender : {0}", sender);

            var note = (Note) BindingContext;    // 기존에 가지고 있던 note의 값을 할당하는것 같다

            if (string.IsNullOrWhiteSpace(note.Filename))
            {
                System.Diagnostics.Debug.WriteLine($"debug --> Path.GetRandomFileName() : {Path.GetRandomFileName()}")
                // save the file
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(filename, note.Text);
            }
            else
            {
                // Update  the file
                System.Diagnostics.Debug.WriteLine($"debug --> note.Filename : {note.Filename}");
                File.WriteAllText(note.Filename, note.Text);
            }

            await Shell.Current.GoToAsync("..");
        }

    }
};