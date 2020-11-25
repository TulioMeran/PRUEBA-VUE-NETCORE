import Vue from 'vue'
import Vuex from 'vuex'
import Axios from 'axios'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    listPermissions: [],
    listPermissionType: [],
    permission: {
      idPermission: null,
      employerName: null,
      employerLastName: null,
      permissionDate: null,
      idPermissionType: null
    },
    urlApi: 'http://localhost:61602/'

  },
  mutations: {
    AllPermissions(state,actionResult){
      debugger
      state.listPermissions = actionResult;
    },
    AllPermissionTypes(state,actionResult){
      debugger
      state.listPermissionType = actionResult;
    },
    savedPermission(state,actionResult){
      debugger
     // state.respuesta = actionResult;
     if(actionResult){
       debugger
        alert('OK');
     } else {
        alert('NOT OKAY')
     }
    },
    erasedPermission(state,actionResult){
      debugger
     // state.respuesta = actionResult;
     if(actionResult){
       debugger
        alert('OK');
     } else {
        alert('NOT OKAY')
     }
    }



    
  },
  actions: {
    async getAllPermissions({commit}){
      debugger

      const permissions = await Axios.get(this.state.urlApi+'api/permission/all');
      debugger
      commit('AllPermissions',permissions.data);


    },
    async getAllPermissionTypes({commit}){
      debugger

      const types = await Axios.get(this.state.urlApi+'api/permission/type/all');
      debugger
      commit('AllPermissionTypes',types.data);


    },
    async savePermission({commit}){
      debugger 
     const response = await Axios.post(this.state.urlApi+'api/permission/save', this.state.permission 
     
        
      );

      this.state.permission = {
       idPermission: null,
       employerLastName: null,
       employerName: null,
       idPermissionType: null,
       permissionDate: null
      }

      debugger
      commit('savedPermission',response.data);
    },
    async erasePermission({commit}){
      debugger
      console.log(this.state.permission)
      const permission = await Axios.post(this.state.urlApi+'api/permission/erase', this.state.permission );
      debugger

      this.state.permission = {
        idPermission: null,
        employerLastName: null,
        employerName: null,
        idPermissionType: null,
        permissionDate: null
       }

      commit('erasedPermission',permission.data);


    }
  },
  modules: {
  }
})
