using Domain.DAO;
using Domain.Entities.Comments;
using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.CategoryForm
{
    public class CategoryPresenter : Presenter
    {
        private readonly ICategoryView _view;
        private readonly CategoryModel _model;

        private readonly ICategoryRepository _categoryRepository;

        private Category _selectedCategory = new Category(Domain.Entities.Comments.Comments.Init(Program.AuthUser, "Category"));
        private BindingList<Comment> _comments = new BindingList<Comment>(); 

        private BindingList<Category> _categories;

        public CategoryPresenter(ICategoryView view, CategoryModel model)
        {
            _view = view;
            _model = model;
            _categoryRepository = _model.CategoryRepository;
            _categories = new BindingList<Category>(_categoryRepository.GetAll().ToList());
        }

        public void UseCategory(Category category)
        {
            _selectedCategory = category;
            _comments = new BindingList<Comment>(_selectedCategory.Comments.ToList());
        }

        private void SaveCategory()
        {
            foreach (var category in _categories)
            {
                if (category.Id != 0)
                {
                    _model.CategoryRepository.Update(category);
                }
                else
                {
                    _model.CategoryRepository.Create(category);
                }
            }
        }

        public void Save()
        {
            SaveCategory();
        }        

        public void AddCategoryWithTitle(string title)
        {
            _categories.Add(new Category(Domain.Entities.Comments.Comments.Init(Program.AuthUser, "Category")) { Title = title });
            NotifyPropertyChanged("Categories");
        }

        public BindingList<Category> Categories
        {
            get { return _categories; }
            set
            {
                if (Equals(value, _categories)) return;
                _categories = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<Comment> Comments
        {
            get { return new BindingList<Comment>(_selectedCategory.Comments.ToList()); }
            set
            {
                if (value.SequenceEqual(_selectedCategory.Comments)) return;
                _selectedCategory.Comments = value;
                NotifyPropertyChanged();
            }
        }
        
        public override void Stop()
        {
            _model.Dispose();
        }


        public void AddCommentToCurrentCategory(string comment)
        {
            _selectedCategory.Comments.Add(new Comment { Author = Program.AuthUser, EntityType = EntityType.Category, Text = comment });
            NotifyPropertyChanged("Comments");
        }
    }
}
