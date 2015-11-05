using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;
using Domain.Entities.Users;

namespace ContosoUI.RoleForm
{
    internal class RolePresenter : Presenter
    {
        private RoleModel _model;
        private IRoleView _view;
        private List<Permission> _avalaiblePermissions = new List<Permission>();

        private Role _role;
        private BindingList<Permission> _currentRolePermissions = new BindingList<Permission>();
        private List<KeyValuePair<Permission, bool>> _checkedPermissions = new List<KeyValuePair<Permission, bool>>();
        
        private BindingList<Role> _avalaibleRoles = new BindingList<Role>();
        List<Role> _changedRoles = new List<Role>(); 

        public RolePresenter(IRoleView view, RoleModel model)
        {
            _view = view;
            _model = model;
            InitializeFields();
        }

        private void InitializeFields()
        {
            _avalaibleRoles = new BindingList<Role>(_model.RoleRepository.GetAll().ToList());
            _avalaiblePermissions = new List<Permission>(_model.PermissionRepository.GetAll().ToList());
        }

        public void UsePermissionWithRoleID(int id)
        {
            if (id != 0)
            {
                _role = _avalaibleRoles.First(x => x.Id == id);
                _currentRolePermissions = new BindingList<Permission>(_role.Permissions.ToList());
                _checkedPermissions.Clear();
                foreach (var permission in _avalaiblePermissions)
                {   
                    _checkedPermissions.Add(new KeyValuePair<Permission, bool>(permission, _currentRolePermissions.Any(x=>x.Title==permission.Title)));
                }
             }
        }

        public void ChangedRole(Role role)
        {
            if (_changedRoles.FirstOrDefault(x => x.Equals(role)) == null)
            {
                _changedRoles.Add(role);
            }
            else
            {
                _changedRoles[_changedRoles.FindIndex(x => x.Id.Equals(role.Id))] = role;
            }
        }

    public Role Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public BindingList<Permission> CurrentRolePermissions
        {
            get { return _currentRolePermissions; }
            set { _currentRolePermissions = value; }
        }

        public List<KeyValuePair<Permission, bool>> CheckedPermissions
        {
            get { return _checkedPermissions; }
            set { _checkedPermissions = value; }
        }

        public BindingList<Role> AvalaibleRoles
        {
            get { return _avalaibleRoles; }
            set
            {
                if (!value.SequenceEqual(_avalaibleRoles))
                {
                    _avalaibleRoles = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public List<Permission> AvalaiblePermissions
        {
            get { return _avalaiblePermissions; }
        }

        public void Save()
        {
            foreach (var role in _changedRoles)
            {
                _model.RoleRepository.Save(role);
            }
        }

        public void SaveAndNew()
        {
            Save();
        }

        public void AddNewRole()
        {
            _model.RoleRepository.Create(new Role(new List<Permission>()) {Title = string.Empty});
            _avalaibleRoles = new BindingList<Role>(_model.RoleRepository.GetAll().ToList());
            NotifyPropertyChanged("AvalaibleRoles");
        }
    }
}
